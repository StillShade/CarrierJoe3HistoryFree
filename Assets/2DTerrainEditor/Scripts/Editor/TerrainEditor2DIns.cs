using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditorInternal;
using UnityEngine;
using UnityEditor;
using Random = UnityEngine.Random;

[CustomEditor(typeof(TerrainEditor2D))]
public class TerrainEditor2DIns: Editor
{
    #region Constants
    private const string SAVED_MESHES_FOLDER = "";
    private const string INSPECTOR_RES_FOLDER = "2DTerrainInspectorRes";
    private const string PREFS_PREFIX = "TerrainEditor2D_";

    private static Dictionary<string, KeyCode> _hotKeys = new Dictionary<string, KeyCode>
    {
        {"SwitchEditMode", KeyCode.E},
        {"DigMode", KeyCode.D},
        {"EditModeUndo", KeyCode.Z},
        {"EditModeRedo", KeyCode.Y},
        {"ShowEditTab", KeyCode.F1},
        {"ShowCapTab", KeyCode.F2},
        {"ShowDeformTab", KeyCode.F3},
        {"ShowMainTab", KeyCode.F4},
    };
    private static string[] _prefKeys = new[]
    {
        PREFS_PREFIX + "BrushSize",                 //0
        PREFS_PREFIX + "BrushHardness",             //1
        PREFS_PREFIX + "BrushNoise",                //2
        PREFS_PREFIX + "BrushHeightLimit",          //3
        PREFS_PREFIX + "BrushHeightLimitEnabled",   //4
        PREFS_PREFIX + "ShowEditSettings",          //5
        PREFS_PREFIX + "ShowCapSettings",           //6
        PREFS_PREFIX + "ShowDeformSettings",        //7
        PREFS_PREFIX + "ShowMainSettings",          //8
    };
    #endregion

    #region Editor settings fields
    private float _brushSize = 5;
    private float _brushHardness = 0.25f;
    private float _brushNoise;
    private float _brushHeightLimit = 50;
    private bool _brushHeightLimOn;

    private bool _showEditTab;
    private bool _showCapTab;
    private bool _showDeformTab;
    private bool _showMainTab;
    #endregion

    #region Operational fields
    private TerrainEditor2D _myTerrainEditor2D;

    private bool _editMode;
    private bool _playMode;
    private bool _startEdit;
    private bool _digMode;
    private bool _brushLockMode;
    private Vector2 _brushHandleLockPos;

    private Vector2 _mousePos;
    private Vector2 _handleLocalPos;

    private List<TerrainVerts> _recordedVerts = new List<TerrainVerts>();
    private TerrainVerts _lastRecordedVerts;
    private int _curUndoRecordedVertsId;

    private Tool _previousUsingTool;

    private Dictionary<string, Texture> _inspectorTextures = new Dictionary<string, Texture>();
    private GUIStyle _guiButtonStyle;
    private Texture2D _guiDefaultButton;
    #endregion

    
    void OnEnable()
    {
        LoadInspector();
        
        _myTerrainEditor2D = target as TerrainEditor2D;

        if (_myTerrainEditor2D == null)
            return;

#if UNITY_2018_3_OR_NEWER
        if (PrefabUtility.GetPrefabAssetType(_myTerrainEditor2D.gameObject) == PrefabAssetType.Regular)
#else
        if (PrefabUtility.GetPrefabType(_myTerrainEditor2D.gameObject) == PrefabType.Prefab)
#endif
            return;

        if (_myTerrainEditor2D.InstanceId != _myTerrainEditor2D.GetInstanceID())
        {
            CopySharedMesh(_myTerrainEditor2D.MeshFilter);
            if (_myTerrainEditor2D.CapObj != null)
                CopySharedMesh(_myTerrainEditor2D.CapObj.GetComponent<MeshFilter>());
            if (_myTerrainEditor2D.Collider3DObj != null)
                CopySharedMesh(_myTerrainEditor2D.Collider3DObj.GetComponent<MeshFilter>());

            _myTerrainEditor2D.SetInstanceId(_myTerrainEditor2D.GetInstanceID());
        }

        _recordedVerts.Add(new TerrainVerts(_myTerrainEditor2D.GetVertsPos()));
    }
    
    void LoadInspector()
    {
        #region Load prefs
        _brushSize = EditorPrefs.GetFloat(_prefKeys[0], 5);
        _brushHardness = EditorPrefs.GetFloat(_prefKeys[1], 0.25f);
        _brushNoise = EditorPrefs.GetFloat(_prefKeys[2], 0);
        _brushHeightLimit = EditorPrefs.GetFloat(_prefKeys[3], 50);
        _brushHeightLimOn = EditorPrefs.GetBool(_prefKeys[4], false);

        _showEditTab = EditorPrefs.GetBool(_prefKeys[5]);
        _showCapTab = EditorPrefs.GetBool(_prefKeys[6]);
        _showDeformTab = EditorPrefs.GetBool(_prefKeys[7]);
        _showMainTab = EditorPrefs.GetBool(_prefKeys[8]);
        #endregion

        string path = GetFolderPath(INSPECTOR_RES_FOLDER);
        path = path.Replace('\\', '/');

        _inspectorTextures["Edit settings"] = (Texture)AssetDatabase.LoadAssetAtPath(path + "2dterrain_inspector_edit_settings_button.png", typeof(Texture));
        _inspectorTextures["Cap settings"] = (Texture)AssetDatabase.LoadAssetAtPath(path + "2dterrain_inspector_cap_settings_button.png", typeof(Texture));
        _inspectorTextures["Deform settings"] = (Texture)AssetDatabase.LoadAssetAtPath(path + "2dterrain_inspector_deform_settings_button.png", typeof(Texture));
        _inspectorTextures["Main settings"] = (Texture)AssetDatabase.LoadAssetAtPath(path + "2dterrain_inspector_main_settings_button.png", typeof(Texture));
    }


    public override void OnInspectorGUI()
    {
        #region Check inspector
        Undo.RecordObject(_myTerrainEditor2D, "2D Terrain Editor");

        if (_myTerrainEditor2D == null)
        {
            EditorGUILayout.HelpBox("Missing object reference", MessageType.Error);
            return;
        }

#if UNITY_2018_3_OR_NEWER
        if (PrefabUtility.GetPrefabAssetType(_myTerrainEditor2D.gameObject) == PrefabAssetType.Regular)
#else
        if (PrefabUtility.GetPrefabType(_myTerrainEditor2D.gameObject) == PrefabType.Prefab)
#endif
        {
            EditorGUILayout.HelpBox("Terrain settings is not avaliable in project view. Please, place this prefab on the scene.", MessageType.Warning);
            return;
        }

        _guiButtonStyle = new GUIStyle(GUI.skin.button);
        _guiDefaultButton = _guiButtonStyle.normal.background;

        string[] sortingLayers = GetSortingLayerNames();
        #endregion

        #region Tab controls
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();

        _guiButtonStyle.overflow.right = 4;
        _guiButtonStyle.overflow.left = 4;

        _guiButtonStyle.normal.background = _guiDefaultButton;
        if (_showEditTab)
            _guiButtonStyle.normal.background = _guiButtonStyle.onActive.background;
        if (GUILayout.Button(new GUIContent(_inspectorTextures["Edit settings"], "Edit mode"), _guiButtonStyle, GUILayout.Height(25), GUILayout.Width(35)) 
            || (Event.current.keyCode == _hotKeys["ShowEditTab"]))
            SwitchTab("Edit settings");

        _guiButtonStyle.normal.background = _guiDefaultButton;
        if (_showCapTab)
            _guiButtonStyle.normal.background = _guiButtonStyle.onActive.background;
        if (GUILayout.Button(new GUIContent(_inspectorTextures["Cap settings"], "Cap settings"), _guiButtonStyle, GUILayout.Height(25), GUILayout.Width(35))
            || (Event.current.keyCode == _hotKeys["ShowCapTab"]))
            SwitchTab("Cap settings");

        _guiButtonStyle.normal.background = _guiDefaultButton;
        if (_showDeformTab)
            _guiButtonStyle.normal.background = _guiButtonStyle.onActive.background;
        if (GUILayout.Button(new GUIContent(_inspectorTextures["Deform settings"], "Realtime deformation settings"), _guiButtonStyle, GUILayout.Height(25), GUILayout.Width(35))
            || (Event.current.keyCode == _hotKeys["ShowDeformTab"]))
            SwitchTab("Deform settings");

        _guiButtonStyle.normal.background = _guiDefaultButton;
        if (_showMainTab)
            _guiButtonStyle.normal.background = _guiButtonStyle.onActive.background;
        if (GUILayout.Button(new GUIContent(_inspectorTextures["Main settings"], "Main settings"), _guiButtonStyle, GUILayout.Height(25), GUILayout.Width(35))
            || (Event.current.keyCode == _hotKeys["ShowMainTab"]))
            SwitchTab("Main settings");
        
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();

        _guiButtonStyle = new GUIStyle(GUI.skin.button);

        #endregion

        #region Edit tab
        if (_showEditTab)
        {
            //Brush settings
            GUI.skin.label.fontStyle = FontStyle.Bold;
            GUILayout.Label("Brush", GUI.skin.label);
            GUI.skin.label.fontStyle = FontStyle.Normal;

            _brushSize = EditorGUILayout.Slider("Size", _brushSize, 0.1f, 50);
            _brushHardness = EditorGUILayout.Slider("Hardness", _brushHardness, 0.01f, 1);
            _brushNoise = EditorGUILayout.Slider("Noise", _brushNoise, 0, 1);

            EditorGUILayout.BeginHorizontal();

            _brushHeightLimOn = EditorGUILayout.Toggle(_brushHeightLimOn, GUILayout.MaxWidth(15));
            
            EditorGUI.BeginDisabledGroup(!_brushHeightLimOn);

            _brushHeightLimit = EditorGUILayout.Slider("Limit height", _brushHeightLimit, 0, _myTerrainEditor2D.Height);
            
            EditorGUI.EndDisabledGroup();
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.Space();

            if (_editMode)
                _guiButtonStyle.normal.background = _guiButtonStyle.onActive.background;

            if (GUILayout.Button("EDIT MODE", _guiButtonStyle, GUILayout.Height(40)))
            {
                SwitchEditMode();
            }

            if (_editMode)
                EditorGUILayout.HelpBox(
                    "Hold [LMB] - raise terrain\n" +
                    "Hold [" + _hotKeys["DigMode"] + " + LMB] - dig mode\n" +
                    "Hold [ALT+Mouse Wheel] - change brush size\n" +
                    "Hold [SHIFT] - horizontal lock\n" +
                    "[SHIFT+" + _hotKeys["EditModeUndo"] + " / " + _hotKeys["EditModeRedo"] + "] - undo / redo",
                    MessageType.None);
            else
            {
                if (GetSceneViewCamera() != null)
                {
                    if (!GetSceneViewCamera().orthographic)
                        EditorGUILayout.HelpBox("Set scene view camera to orthographic or 2D mode to enter edit mode.", MessageType.Warning);
                    else EditorGUILayout.HelpBox("Use [Shift+" + _hotKeys["SwitchEditMode"] + "] to enter Edit Mode", MessageType.None);
                }
            }

            EditorGUILayout.Space();

            //Randomizer
            GUI.skin.label.fontStyle = FontStyle.Bold;
            GUILayout.Label("Random generation", GUI.skin.label);
            GUI.skin.label.fontStyle = FontStyle.Normal;
            
            _myTerrainEditor2D.RndHeight = EditorGUILayout.Slider("Average height", _myTerrainEditor2D.RndHeight, 0.1f, _myTerrainEditor2D.Height);
            _myTerrainEditor2D.RndHillsCount = EditorGUILayout.IntSlider("Hills count", _myTerrainEditor2D.RndHillsCount, 1, _myTerrainEditor2D.Width / 2);
            _myTerrainEditor2D.RndAmplitude = EditorGUILayout.Slider("Amplitude", _myTerrainEditor2D.RndAmplitude, 0.1f, _myTerrainEditor2D.Height / 2f);

            if (GUILayout.Button("Generate"))
            {
                _myTerrainEditor2D.RandomizeTerrain(true);
            }

            //Check transform
            if (_myTerrainEditor2D.transform.rotation.eulerAngles != Vector3.zero || _myTerrainEditor2D.transform.localScale != Vector3.one)
            {
                EditorGUILayout.HelpBox("Object rotation or scale is different from default. Edit mode may not work properly.", MessageType.Warning);
            }
        }
        
        #endregion

        #region Cap tab
        if (_showCapTab)
        {
            GUI.skin.label.fontStyle = FontStyle.Bold;
            GUILayout.Label("Cap", GUI.skin.label);
            GUI.skin.label.fontStyle = FontStyle.Normal;

            _myTerrainEditor2D.GenerateCap = EditorGUILayout.Toggle("Enabled", _myTerrainEditor2D.GenerateCap);

            EditorGUI.BeginDisabledGroup(!_myTerrainEditor2D.GenerateCap);

            _myTerrainEditor2D.CapMaterial = (Material)EditorGUILayout.ObjectField("Material", _myTerrainEditor2D.CapMaterial, typeof(Material), false);
            CheckTexture(_myTerrainEditor2D.CapMaterial);
            _myTerrainEditor2D.CapColor = EditorGUILayout.ColorField(new GUIContent("Color", "Color of cap mesh. Works only if shader supports vertex colors."), _myTerrainEditor2D.CapColor);

            _myTerrainEditor2D.CapHeight = EditorGUILayout.FloatField(new GUIContent("Height", "Cap height in units"), _myTerrainEditor2D.CapHeight);
            _myTerrainEditor2D.CapOffset = EditorGUILayout.FloatField(new GUIContent("Offset", "Offset relative to base terrain path"), _myTerrainEditor2D.CapOffset);

            EditorGUI.BeginDisabledGroup(_myTerrainEditor2D.SmartCap);

            _myTerrainEditor2D.CapTextureTiling = EditorGUILayout.IntField(new GUIContent("Texture tiling", "Number of cap texture tiles for whole 2D terrain (does not affect to cap if smart cap enabled)"), _myTerrainEditor2D.CapTextureTiling);
            EditorGUI.EndDisabledGroup();

            _myTerrainEditor2D.CapSortingLayerId = EditorGUILayout.Popup("Sorting layer", _myTerrainEditor2D.CapSortingLayerId, sortingLayers);
            _myTerrainEditor2D.CapSortingLayerName = sortingLayers[_myTerrainEditor2D.CapSortingLayerId];

            _myTerrainEditor2D.CapOrderInLayer = EditorGUILayout.IntField("Order in layer", _myTerrainEditor2D.CapOrderInLayer);

            EditorGUILayout.Space();

            GUI.skin.label.fontStyle = FontStyle.Bold;
            GUILayout.Label("Smart cap", GUI.skin.label);
            GUI.skin.label.fontStyle = FontStyle.Normal;

            _myTerrainEditor2D.SmartCap = EditorGUILayout.Toggle("Enabled", _myTerrainEditor2D.SmartCap);

            EditorGUI.BeginDisabledGroup(!_myTerrainEditor2D.SmartCap);
            _myTerrainEditor2D.SmartCapCutHeight = EditorGUILayout.FloatField(new GUIContent("Cut height", "Min height in units for splitting cap into different paths"), _myTerrainEditor2D.SmartCapCutHeight);
            _myTerrainEditor2D.SmartCapSegmentsUv = EditorGUILayout.Vector2Field(new GUIContent("Segments UV", "Horizontal UV for smart cap texture. It's like separator which divides cap texture into 3 parts."), _myTerrainEditor2D.SmartCapSegmentsUv);
            _myTerrainEditor2D.SmartCapSideSegmentsWidth = EditorGUILayout.FloatField("Side segments width", _myTerrainEditor2D.SmartCapSideSegmentsWidth);

            EditorGUI.EndDisabledGroup();

            EditorGUI.EndDisabledGroup();
        }
        #endregion

        #region Deform tab

        if (_showDeformTab)
        {
            GUI.skin.label.fontStyle = FontStyle.Bold;
            GUILayout.Label("Realtime deformation", GUI.skin.label);
            GUI.skin.label.fontStyle = FontStyle.Normal;

            _myTerrainEditor2D.RealtimeDeformEnabled = EditorGUILayout.Toggle("Enabled", _myTerrainEditor2D.RealtimeDeformEnabled);
            
            EditorGUI.BeginDisabledGroup(!_myTerrainEditor2D.RealtimeDeformEnabled);

            _myTerrainEditor2D.RealtimeDeformUpdateColliders = EditorGUILayout.Toggle(new GUIContent("Update colliders", 
                "Is colliders should be updated on each iteration of deformation?"), _myTerrainEditor2D.RealtimeDeformUpdateColliders);
            _myTerrainEditor2D.RealtimeDeformUpdateUv = EditorGUILayout.Toggle(new GUIContent("Update UV",
                "Is UV texture coordinates should be updated on each iteration of deformation?"), _myTerrainEditor2D.RealtimeDeformUpdateUv);

            EditorGUI.EndDisabledGroup();

            EditorGUILayout.HelpBox("Read the documentation to leran how realtime deformation works", MessageType.None);
            EditorGUILayout.HelpBox("Note that updating 2D collider is very expensive operation due to 2D physics specificity", MessageType.None);
        }
        #endregion

        #region Main tab
        if (_showMainTab)
        {
            EditorGUI.BeginChangeCheck();

            //Main
            GUI.skin.label.fontStyle = FontStyle.Bold;
            GUILayout.Label("Main", GUI.skin.label);
            GUI.skin.label.fontStyle = FontStyle.Normal;

            EditorGUI.BeginDisabledGroup(true);
            EditorGUILayout.IntField("Mesh ID", _myTerrainEditor2D.InstanceId);
            EditorGUI.EndDisabledGroup();

            _myTerrainEditor2D.MainMaterial = (Material)EditorGUILayout.ObjectField("Material", _myTerrainEditor2D.MainMaterial, typeof(Material), false);
            CheckTexture(_myTerrainEditor2D.MainMaterial);
            _myTerrainEditor2D.MainColor = EditorGUILayout.ColorField(new GUIContent("Color", "Color of 2D terrain mesh. Works only if shader supports vertex colors."), _myTerrainEditor2D.MainColor);

            _myTerrainEditor2D.MainTextureSize = EditorGUILayout.IntField("Texture size", _myTerrainEditor2D.MainTextureSize);

            _myTerrainEditor2D.SortingLayerId = EditorGUILayout.Popup("Sorting layer", _myTerrainEditor2D.SortingLayerId, sortingLayers);
            _myTerrainEditor2D.SortingLayerName = sortingLayers[_myTerrainEditor2D.SortingLayerId];

            _myTerrainEditor2D.OrderInLayer = EditorGUILayout.IntField("Order in layer", _myTerrainEditor2D.OrderInLayer);

            //Additionally
            EditorGUILayout.Space();

            GUI.skin.label.fontStyle = FontStyle.Bold;
            GUILayout.Label("Additionally", GUI.skin.label);
            GUI.skin.label.fontStyle = FontStyle.Normal;
            
            _myTerrainEditor2D.FixSides = EditorGUILayout.Toggle(new GUIContent("Fix sides", 
                "Is side end points of terrain 2D path needs to be fixed and protected from changes? "), _myTerrainEditor2D.FixSides);
            EditorGUI.BeginDisabledGroup(!_myTerrainEditor2D.FixSides);
            _myTerrainEditor2D.LeftFixedPoint = EditorGUILayout.FloatField("Left fixed point", _myTerrainEditor2D.LeftFixedPoint);
            _myTerrainEditor2D.RightFixedPoint = EditorGUILayout.FloatField("Right fixed point", _myTerrainEditor2D.RightFixedPoint);
            EditorGUI.EndDisabledGroup();

            _myTerrainEditor2D.Generate3DCollider = EditorGUILayout.Toggle("3D collider", _myTerrainEditor2D.Generate3DCollider);
            EditorGUI.BeginDisabledGroup(!_myTerrainEditor2D.Generate3DCollider);
            _myTerrainEditor2D.Collider3DWidth = EditorGUILayout.FloatField("3D collider width", _myTerrainEditor2D.Collider3DWidth);
            EditorGUI.EndDisabledGroup();
            
            //Resolution
            EditorGUILayout.Space();

            GUI.skin.label.fontStyle = FontStyle.Bold;
            GUILayout.Label("Size and resolution", GUI.skin.label);
            GUI.skin.label.fontStyle = FontStyle.Normal;

            _myTerrainEditor2D.Width = EditorGUILayout.IntField("Width", _myTerrainEditor2D.Width);
            _myTerrainEditor2D.Height = EditorGUILayout.IntField("Height", _myTerrainEditor2D.Height);
            _myTerrainEditor2D.Resolution = EditorGUILayout.IntField("Resolution", _myTerrainEditor2D.Resolution);

            if (_myTerrainEditor2D.Resolution > 8)
                EditorGUILayout.HelpBox("Resolution is responsible for the number of polygons. High resolution value may affect performance.", MessageType.Warning);

            if (GUILayout.Button("Apply"))
            {
                _recordedVerts.Clear();
                _curUndoRecordedVertsId = 0;
                _myTerrainEditor2D.Create();
                _recordedVerts.Add(new TerrainVerts(_myTerrainEditor2D.GetVertsPos()));
            }
            EditorGUILayout.HelpBox("Applying will clear all changes in geometry", MessageType.None);
            
        }
        #endregion

        #region Check colliders
        if (EditorApplication.isPlaying && !_playMode)
        {
            _myTerrainEditor2D.UpdateCollider2D();

            if (_myTerrainEditor2D.Generate3DCollider)
            {
                _myTerrainEditor2D.UpdateCollider3D(false);
            }

            _playMode = true;
        }
        else _playMode = false;
        #endregion

        if (GUI.changed)
        {
            CheckValues();
            _myTerrainEditor2D.EditTerrain(_myTerrainEditor2D.GetVertsPos(), !EditorApplication.isPlaying);

            EditorUtility.SetDirty(target);
        }
    }

    void OnSceneGUI()
    {
#if UNITY_2018_3_OR_NEWER
        if (PrefabUtility.GetPrefabAssetType(_myTerrainEditor2D.gameObject) == PrefabAssetType.Regular || _myTerrainEditor2D == null)
#else
        if (PrefabUtility.GetPrefabType(_myTerrainEditor2D.gameObject) == PrefabType.Prefab || _myTerrainEditor2D == null)
#endif
            return;

        #region Scene view events
        //Switch tab
        if (Event.current.type == EventType.KeyUp)
        {
            if (Event.current.keyCode == _hotKeys["ShowEditTab"])
                SwitchTab("Edit settings");
            if (Event.current.keyCode == _hotKeys["ShowCapTab"])
                SwitchTab("Cap settings");
            if (Event.current.keyCode == _hotKeys["ShowMainTab"])
                SwitchTab("Main settings");
        }
        

        if (Event.current.Equals(Event.KeyboardEvent("#" + _hotKeys["SwitchEditMode"])))
            SwitchEditMode();

        //Undo & redo (values)
        if (Event.current.commandName == "UndoRedoPerformed")
        {
            if (!EditorApplication.isPlaying)
                _myTerrainEditor2D.EditTerrain(_myTerrainEditor2D.GetVertsPos(), true);
            else _myTerrainEditor2D.EditTerrain(_myTerrainEditor2D.GetVertsPos(), false);
        }

        #endregion

        if (!_editMode)
            return;

        #region Draw handles
        if (GetSceneViewCamera() != null)
        {
            _mousePos = Camera.current.ScreenToWorldPoint(new Vector2(Event.current.mousePosition.x, (Camera.current.pixelHeight - Event.current.mousePosition.y)));
            _handleLocalPos = _mousePos - new Vector2(_myTerrainEditor2D.transform.position.x, _myTerrainEditor2D.transform.position.y);
            if (_brushLockMode)
                _handleLocalPos.y = _brushHandleLockPos.y;

            Vector2 finalHandlePos = _handleLocalPos + (Vector2)_myTerrainEditor2D.transform.position;
            Handles.color = Color.green;
            Handles.CircleHandleCap(0, finalHandlePos, Quaternion.identity, _brushSize, EventType.Repaint);

            if (_brushLockMode)
            {
                Handles.DrawLine(finalHandlePos + new Vector2(-_brushSize, _brushSize), finalHandlePos + new Vector2(_brushSize, _brushSize));
                Handles.DrawLine(finalHandlePos + new Vector2(-_brushSize, -_brushSize), finalHandlePos + new Vector2(_brushSize, -_brushSize));
            }

            //Draw cap tile errors
            if (_myTerrainEditor2D.GenerateCap && _myTerrainEditor2D.SmartCap)
            {
                if (_myTerrainEditor2D.SmartCapAreas != null)
                {
                    foreach (var smartCapArea in _myTerrainEditor2D.SmartCapAreas)
                    {
                        Handles.color = Color.red;
                        if (smartCapArea.CorruptedTilesVertsPoints.Count >= 2)
                        {
                            Handles.DrawLine(smartCapArea.CorruptedTilesVertsPoints[0] + _myTerrainEditor2D.transform.position, smartCapArea.CorruptedTilesVertsPoints[1] + _myTerrainEditor2D.transform.position);
                        }
                            
                        Handles.color = Color.green;
                    }
                }
            }

        }
        #endregion

        #region Draw terrain borders
        Vector3 terrainPos = _myTerrainEditor2D.transform.position;
        Handles.color = new Color(1, 1, 1, 0.5f);
        Handles.DrawLine(terrainPos, terrainPos + new Vector3(0, _myTerrainEditor2D.Height));
        Handles.DrawLine(terrainPos, terrainPos + new Vector3(_myTerrainEditor2D.Width, 0));
        Handles.DrawLine(terrainPos + new Vector3(0, _myTerrainEditor2D.Height), terrainPos + new Vector3(0, _myTerrainEditor2D.Height) + new Vector3(_myTerrainEditor2D.Width, 0));
        Handles.DrawLine(terrainPos + new Vector3(_myTerrainEditor2D.Width, 0), terrainPos + new Vector3(0, _myTerrainEditor2D.Height) + new Vector3(_myTerrainEditor2D.Width, 0));

        if (_myTerrainEditor2D.FixSides)
        {
            Vector3 leftFixedPoint = terrainPos + new Vector3(0, _myTerrainEditor2D.LeftFixedPoint);
            Vector3 rightFixedPoint = terrainPos + new Vector3(_myTerrainEditor2D.Width, _myTerrainEditor2D.RightFixedPoint);
            Handles.DrawLine(leftFixedPoint, leftFixedPoint - new Vector3(1, 0));
            Handles.DrawLine(rightFixedPoint, rightFixedPoint + new Vector3(1, 0));
        }

        #endregion

        #region Edit mode events
        //Start edit
        if (Event.current.type == EventType.MouseDown && Event.current.button == 0)
            _startEdit = true;

        //End edit
        if (Event.current.type == EventType.MouseUp)
        {
            _startEdit = false;

            //Register custom undo
            _lastRecordedVerts = new TerrainVerts(_myTerrainEditor2D.GetVertsPos());
            if (_recordedVerts.Count > 0)
            {
                if (_recordedVerts[_recordedVerts.Count - 1] != _lastRecordedVerts)
                {
                    if (_curUndoRecordedVertsId < _recordedVerts.Count - 1)
                        _recordedVerts.RemoveRange(_curUndoRecordedVertsId + 1, (_recordedVerts.Count - _curUndoRecordedVertsId - 1));

                    if (_recordedVerts.Count > 75)
                        _recordedVerts.RemoveAt(0);

                    _recordedVerts.Add(_lastRecordedVerts);
                    _curUndoRecordedVertsId = _recordedVerts.Count - 1;
                }
            }
            else _recordedVerts.Add(_lastRecordedVerts);
        }

        //Dig mode
        if (Event.current.keyCode == _hotKeys["DigMode"])
        {
            if (Event.current.type == EventType.KeyDown)
                _digMode = true;
            if (Event.current.type == EventType.KeyUp)
                _digMode = false;
        }

        //Brush lock
        if (Event.current.shift)
        {
            if (!_brushLockMode)
            {
                _brushHandleLockPos = _handleLocalPos;
                _brushLockMode = true;
            }
        }
        else _brushLockMode = false;

        //Brush size
        if (Event.current.alt)
        {
            if (Event.current.type == EventType.ScrollWheel)
            {
                float sizeDelta = 0.2f;
                if (Event.current.control)
                    sizeDelta += 0.8f;

                if (Event.current.delta.y > 0)
                    _brushSize -= sizeDelta;
                if (Event.current.delta.y < 0)
                    _brushSize += sizeDelta;

                Event.current.Use();
            }
            if (_brushSize <= 0.1f)
                _brushSize = 0.1f;
        }

        //Undo & redo (edit Mode)
        if (Event.current.shift)
        {
            if (Event.current.type == EventType.KeyUp)
            {
                //Undo
                if (Event.current.keyCode == _hotKeys["EditModeUndo"])
                {
                    if (_recordedVerts.Count > 0 && _curUndoRecordedVertsId > 0)
                    {
                        _curUndoRecordedVertsId--;
                        _myTerrainEditor2D.EditTerrain(_recordedVerts[_curUndoRecordedVertsId].Verts, true);
                    }
                }

                //Redo
                if (Event.current.keyCode == _hotKeys["EditModeRedo"])
                {
                    if (_curUndoRecordedVertsId < _recordedVerts.Count - 1)
                    {
                        _curUndoRecordedVertsId++;
                        _myTerrainEditor2D.EditTerrain(_recordedVerts[_curUndoRecordedVertsId].Verts, true);
                    }
                }
            }
        }

        #endregion

        #region Start edit mesh
        if (_startEdit)
        {
            Vector3[] vertsPos = _myTerrainEditor2D.GetVertsPos();

            for (int i = 0; i < vertsPos.Length; i += 2)
            {
                if (Vector2.Distance(vertsPos[i], _handleLocalPos) <= _brushSize)
                {
                    float vertOffset = _brushSize - Vector2.Distance(vertsPos[i], _handleLocalPos);

                    if (_digMode)
                        vertsPos[i] -= new Vector3(0, vertOffset * (_brushHardness * 0.1f));
                    else vertsPos[i] += new Vector3(0, vertOffset * (_brushHardness * 0.1f));

                    if (_brushNoise > 0f)
                        vertsPos[i] += new Vector3(0, Random.Range(-_brushNoise * 0.25f, _brushNoise * 0.25f));

                    if (_brushHeightLimOn)
                        if (vertsPos[i].y > _brushHeightLimit)
                            vertsPos[i].y = _brushHeightLimit;

                    if (vertsPos[i].y < 0)
                        vertsPos[i].y = 0;
                    if (vertsPos[i].y > _myTerrainEditor2D.Height)
                        vertsPos[i].y = _myTerrainEditor2D.Height;

                }
            }

            if (!EditorApplication.isPlaying)
                _myTerrainEditor2D.EditTerrain(vertsPos, true);
            else _myTerrainEditor2D.EditTerrain(vertsPos, false);

            Selection.activeGameObject = _myTerrainEditor2D.gameObject;
        }
        #endregion

        #region Configure handles
        HandleUtility.AddDefaultControl(GUIUtility.GetControlID(FocusType.Passive));
        if (_myTerrainEditor2D.MeshRenderer != null)
            EditorUtility.SetSelectedRenderState(_myTerrainEditor2D.MeshRenderer, EditorSelectedRenderState.Hidden);
        if (_myTerrainEditor2D.CapObj != null && _myTerrainEditor2D.CapObj.GetComponent<Renderer>() != null)
            EditorUtility.SetSelectedRenderState(_myTerrainEditor2D.CapObj.GetComponent<Renderer>(), EditorSelectedRenderState.Hidden);
        #endregion

        SceneView.RepaintAll();
        EditorUtility.SetDirty(_myTerrainEditor2D);
    }

    void OnDisable()
    {
        #region Save prefs
        EditorPrefs.SetFloat(_prefKeys[0], _brushSize);
        EditorPrefs.SetFloat(_prefKeys[1], _brushHardness);
        EditorPrefs.SetFloat(_prefKeys[2], _brushNoise);
        EditorPrefs.SetFloat(_prefKeys[3], _brushHeightLimit);
        EditorPrefs.SetBool(_prefKeys[4], _brushHeightLimOn);

        EditorPrefs.SetBool(_prefKeys[5], _showEditTab);
        EditorPrefs.SetBool(_prefKeys[6], _showCapTab);
        EditorPrefs.SetBool(_prefKeys[7], _showDeformTab);
        EditorPrefs.SetBool(_prefKeys[8], _showMainTab);
        #endregion

#if UNITY_2018_3_OR_NEWER
        if (PrefabUtility.GetPrefabAssetType(_myTerrainEditor2D.gameObject) == PrefabAssetType.Regular)
#else
        if (PrefabUtility.GetPrefabType(_myTerrainEditor2D.gameObject) == PrefabType.Prefab)
#endif
            return;

        if (_editMode)
            SwitchEditMode();

        _myTerrainEditor2D.UpdateCollider2D();

        if (_myTerrainEditor2D.Collider3DObj != null)
            InternalEditorUtility.SetIsInspectorExpanded(_myTerrainEditor2D.Collider3DObj.GetComponent<MeshCollider>(), true);
        if (_myTerrainEditor2D.GetComponent<EdgeCollider2D>())
            InternalEditorUtility.SetIsInspectorExpanded(_myTerrainEditor2D.GetComponent<EdgeCollider2D>(), true);
        if (_myTerrainEditor2D.GetComponent<PolygonCollider2D>())
            InternalEditorUtility.SetIsInspectorExpanded(_myTerrainEditor2D.GetComponent<PolygonCollider2D>(), true);

        #region Save meshes
        if (!EditorApplication.isPlaying)
        {
            SaveMesh(_myTerrainEditor2D.MeshFilter.sharedMesh);
            if (_myTerrainEditor2D.GenerateCap)
            {
                if (_myTerrainEditor2D.CapObj != null)
                    SaveMesh(_myTerrainEditor2D.CapObj.GetComponent<MeshFilter>().sharedMesh);
                else _myTerrainEditor2D.GenerateCap = false;
            }

            if (_myTerrainEditor2D.Generate3DCollider)
            {
                if (_myTerrainEditor2D.Collider3DObj != null)
                {
                    SaveMesh(_myTerrainEditor2D.Collider3DObj.GetComponent<MeshFilter>().sharedMesh);
                    _myTerrainEditor2D.Collider3DObj.GetComponent<MeshCollider>().enabled = false;
                    _myTerrainEditor2D.Collider3DObj.GetComponent<MeshCollider>().enabled = true;
                }
                else _myTerrainEditor2D.Generate3DCollider = false;
            }
        }
        #endregion

        
    }

    void SwitchTab(string tabName)
    {
        _showEditTab = false;
        _showCapTab = false;
        _showDeformTab = false;
        _showMainTab = false;

        switch (tabName)
        {
            case "Edit settings":
                _showEditTab = true;
                break;

            case "Cap settings":
                _showCapTab = true;
                break;

            case "Deform settings":
                _showDeformTab = true;
                break;

            case "Main settings":
                _showMainTab = true;
                break;
        }

        Repaint();
    }

    void SwitchEditMode()
    {
        if (GetSceneViewCamera() != null)
            if (!_editMode && !GetSceneViewCamera().orthographic)
                return;

        _editMode = !_editMode;

        if (_editMode)
        {
            if (_myTerrainEditor2D.Collider3DObj != null)
                InternalEditorUtility.SetIsInspectorExpanded(_myTerrainEditor2D.Collider3DObj.GetComponent<MeshCollider>(), false);
            if (_myTerrainEditor2D.GetComponent<EdgeCollider2D>())
                InternalEditorUtility.SetIsInspectorExpanded(_myTerrainEditor2D.GetComponent<EdgeCollider2D>(), false);
            if (_myTerrainEditor2D.GetComponent<PolygonCollider2D>())
                InternalEditorUtility.SetIsInspectorExpanded(_myTerrainEditor2D.GetComponent<PolygonCollider2D>(), false);
            _previousUsingTool = Tools.current;
            Tools.current = Tool.None;
        }
        else Tools.current = _previousUsingTool;
    }

    void CheckTexture(Material mat)
    {
        if (mat == null || !mat.HasProperty("_MainTex"))
            return;

        mat.mainTexture = (Texture)EditorGUILayout.ObjectField("Main Texture", mat.mainTexture, typeof(Texture), false, GUILayout.MaxHeight(15));

        if (mat.mainTexture != null)
            if (mat.mainTexture.wrapMode != TextureWrapMode.Repeat)
                EditorGUILayout.HelpBox("Material texture wrap mode must be set to Repeat for correct tiling", MessageType.Warning);
        
    }

    void CheckValues()
    {
        if (_myTerrainEditor2D.Width < 10)
            _myTerrainEditor2D.Width = 10;
        if (_myTerrainEditor2D.Height < 10)
            _myTerrainEditor2D.Height = 10;
        if (_myTerrainEditor2D.Resolution < 1)
            _myTerrainEditor2D.Resolution = 1;
        if (_myTerrainEditor2D.CapHeight < 0.1f)
            _myTerrainEditor2D.CapHeight = 0.1f;
        if (_myTerrainEditor2D.LeftFixedPoint < 0)
            _myTerrainEditor2D.LeftFixedPoint = 0;
        if (_myTerrainEditor2D.LeftFixedPoint > _myTerrainEditor2D.Height)
            _myTerrainEditor2D.LeftFixedPoint = _myTerrainEditor2D.Height;
        if (_myTerrainEditor2D.RightFixedPoint < 0)
            _myTerrainEditor2D.RightFixedPoint = 0;
        if (_myTerrainEditor2D.RightFixedPoint > _myTerrainEditor2D.Height)
            _myTerrainEditor2D.RightFixedPoint = _myTerrainEditor2D.Height;
        if (_myTerrainEditor2D.SmartCapCutHeight < 0.01f)
            _myTerrainEditor2D.SmartCapCutHeight = 0.01f;
        if (_myTerrainEditor2D.SmartCapSideSegmentsWidth < 0)
            _myTerrainEditor2D.SmartCapSideSegmentsWidth = 0;

        _myTerrainEditor2D.MeshRenderer.material = _myTerrainEditor2D.MainMaterial;
        if (_myTerrainEditor2D.GenerateCap)
            if (_myTerrainEditor2D.CapObj != null)
                _myTerrainEditor2D.CapObj.GetComponent<Renderer>().material = _myTerrainEditor2D.CapMaterial;
    }

    void CopySharedMesh(MeshFilter meshFilter)
    {
        Mesh sharedMesh = meshFilter.sharedMesh;
        Mesh newMesh = new Mesh
        {
            vertices = sharedMesh.vertices,
            triangles = sharedMesh.triangles,
            normals = sharedMesh.normals,
            uv = sharedMesh.uv
        };

        newMesh.RecalculateBounds();

        newMesh.name = sharedMesh.name.Remove(sharedMesh.name.LastIndexOf('_') + 1, (sharedMesh.name.Length - sharedMesh.name.LastIndexOf('_') - 1));
        newMesh.name += _myTerrainEditor2D.GetInstanceID();

        meshFilter.sharedMesh = newMesh;
    }

    void SaveMesh(Mesh mesh)
    {
#if UNITY_2018_3_OR_NEWER
        if (PrefabUtility.GetPrefabAssetType(_myTerrainEditor2D.gameObject) == PrefabAssetType.Regular)
#else
        if (PrefabUtility.GetPrefabType(_myTerrainEditor2D.gameObject) == PrefabType.Prefab)
#endif
            return;

        string path = GetFolderPath("2DTerrainSavedMeshes");

        AssetDatabase.Refresh();

        if (!AssetDatabase.Contains(mesh))
            AssetDatabase.CreateAsset(mesh, path + mesh.name + ".asset");
        

        AssetDatabase.SaveAssets();
    }


    
    string[] GetSortingLayerNames()
    {
        Type internalEditorUtilityType = typeof(InternalEditorUtility);
        
        PropertyInfo sortingLayersProperty = internalEditorUtilityType.GetProperty("sortingLayerNames", BindingFlags.Static | BindingFlags.NonPublic);
        return (string[])sortingLayersProperty.GetValue(null, new object[0]);
    }

    string GetFolderPath(string folderName)
    {
        string[] targetDirs = Directory.GetDirectories(Application.dataPath, folderName, SearchOption.AllDirectories);
        if (targetDirs.Length == 0)
            return "Assets/";
        
        return targetDirs[0].Remove(0, targetDirs[0].IndexOf("/Assets", StringComparison.Ordinal) + 1) + "\\";
    }

    Camera GetSceneViewCamera()
    {
        if (SceneView.lastActiveSceneView != null)
            if (SceneView.lastActiveSceneView.camera != null)
                return SceneView.lastActiveSceneView.camera;

        return null;
    }


    [MenuItem("GameObject/2D Object/Terrain 2D")]
    static void CreateNew()
    {
        TerrainEditor2D t = TerrainEditor2D.CreateNew(Vector3.zero);

        t.SetInstanceId(t.gameObject.GetInstanceID());
        t.Create();

        Selection.activeGameObject = t.gameObject;

        Undo.RegisterCreatedObjectUndo(t.gameObject, "Terrain 2D object");
    }


    struct TerrainVerts
    {
        public Vector3[] Verts;

        public TerrainVerts(Vector3[] verts)
        {
            Verts = verts;
        }

        
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((TerrainVerts)obj);
        }

        public override int GetHashCode()
        {
            return (Verts != null ? Verts.GetHashCode() : 0);
        }


        public static bool operator ==(TerrainVerts t1, TerrainVerts t2)
        {
            if (t1.Verts.Length != t2.Verts.Length)
                return false;

            for (int i = 0; i < t1.Verts.Length; i++)
                if (t1.Verts[i] != t2.Verts[i])
                    return false;

            return true;
        }

        public static bool operator !=(TerrainVerts t1, TerrainVerts t2)
        {
            return !(t1 == t2);
        }
    }
}