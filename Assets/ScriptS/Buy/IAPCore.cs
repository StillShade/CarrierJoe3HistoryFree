using System;
using UnityEngine;
using UnityEngine.Purchasing; //���������� � ���������, ����� �������� ����� ���������� �������

public class IAPCore : MonoBehaviour, IStoreListener //��� ��������� ��������� �� Unity Purchasing
{
    [SerializeField] private GameObject panelAds;    

    private static IStoreController m_StoreController;          //������ � ������� Unity Purchasing
    private static IExtensionProvider m_StoreExtensionProvider; // ���������� ������� ��� ���������� ���������

    public static string no_ads = "no_ads"; //����������� - nonconsumable    
    public static string dollars100 = "dollars100"; //������������ - consumable
    public static string dollars250 = "dollars250"; //������������ - consumable
    public static string dollars500 = "dollars500"; //������������ - consumable
    public static string dollars1000 = "dollars1000"; //������������ - consumable
    public static string dollars2500 = "dollars2500"; //������������ - consumable

    void Start()
    {
        if (m_StoreController == null) //���� ��� �� ���������������� ������� Unity Purchasing, ����� ��������������
        {
            InitializePurchasing();
        }
    }

    public void InitializePurchasing()
    {
        if (IsInitialized()) //���� ��� ���������� � ������� - ������� �� �������
        {
            return;
        }

        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

        //����������� ���� ������ ��� ���������� � ������
        builder.AddProduct(no_ads, ProductType.NonConsumable);
        builder.AddProduct(dollars100, ProductType.Consumable);
        builder.AddProduct(dollars250, ProductType.Consumable);
        builder.AddProduct(dollars500, ProductType.Consumable);
        builder.AddProduct(dollars1000, ProductType.Consumable);
        builder.AddProduct(dollars2500, ProductType.Consumable);

        UnityPurchasing.Initialize(this, builder);
    }

    public void Buy_noAds()
    {
        BuyProductID(no_ads);
    }     

    public void Buy_dollars100()
    {
        BuyProductID(dollars100);
    }
    public void Buy_dollars250()
    {
        BuyProductID(dollars250);
    }
    public void Buy_dollars500()
    {
        BuyProductID(dollars500);
    }
    public void Buy_dollars1000()
    {
        BuyProductID(dollars1000);
    }
    public void Buy_dollars2500()
    {
        BuyProductID(dollars2500);
    }
    void BuyProductID(string productId)
    {
        if (IsInitialized()) //���� ������� ���������������� 
        {
            Product product = m_StoreController.products.WithID(productId); //������� ������� ������� 

            if (product != null && product.availableToPurchase) //���� ������� ������ � ����� ��� �������
            {
                Debug.Log(string.Format("Purchasing product asychronously: '{0}'", product.definition.id));
                m_StoreController.InitiatePurchase(product); //��������
            }
            else
            {
                Debug.Log("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
            }
        }
        else
        {
            Debug.Log("BuyProductID FAIL. Not initialized.");
        }
    }

    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args) //�������� �������
    {
        if (String.Equals(args.purchasedProduct.definition.id, no_ads, StringComparison.Ordinal)) //��� �������� ��� ID
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));

            //�������� ��� �������
            Main.Ads = 1;
            panelAds.SetActive(false);   
        }        
        else if (String.Equals(args.purchasedProduct.definition.id, dollars100, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));

            //�������� ��� �������
            Main.Dollars += 100;
        }
        else if (String.Equals(args.purchasedProduct.definition.id, dollars250, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));

            //�������� ��� �������
            Main.Dollars += 250;
        }
        else if (String.Equals(args.purchasedProduct.definition.id, dollars500, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));

            //�������� ��� �������
            Main.Dollars += 500;
        }
        else if (String.Equals(args.purchasedProduct.definition.id, dollars1000, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));

            //�������� ��� �������
            Main.Dollars += 1000;
        }
        else if (String.Equals(args.purchasedProduct.definition.id, dollars2500, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));

            //�������� ��� �������
            Main.Dollars += 2500;
        }
        else
        {
            Debug.Log(string.Format("ProcessPurchase: FAIL. Unrecognized product: '{0}'", args.purchasedProduct.definition.id));
        }

        return PurchaseProcessingResult.Complete;
    }

    public void RestorePurchases() //�������������� ������� (������ ��� Apple). � ���� ��� �������������� �������.
    {
        if (!IsInitialized())
        {
            Debug.Log("RestorePurchases FAIL. Not initialized.");
            return;
        }

        if (Application.platform == RuntimePlatform.IPhonePlayer ||
            Application.platform == RuntimePlatform.OSXPlayer) //���� ��������� �� ��� ����������
        {
            Debug.Log("RestorePurchases started ...");

            var apple = m_StoreExtensionProvider.GetExtension<IAppleExtensions>();

            apple.RestoreTransactions((result) =>
            {
                Debug.Log("RestorePurchases continuing: " + result + ". If no further messages, no purchases available to restore.");
            });
        }
        else
        {
            Debug.Log("RestorePurchases FAIL. Not supported on this platform. Current = " + Application.platform);
        }
    }

    private void Awake()
    {
        if (Main.Ads == 0)
        {
            panelAds.SetActive(true);
        }
        else
        {
            panelAds.SetActive(false);
        }        
    }

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        Debug.Log("OnInitialized: PASS");
        m_StoreController = controller;
        m_StoreExtensionProvider = extensions;
    }

    private bool IsInitialized()
    {
        return m_StoreController != null && m_StoreExtensionProvider != null;
    }

    public void OnInitializeFailed(InitializationFailureReason error)
    {
        Debug.Log("OnInitializeFailed InitializationFailureReason:" + error);
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log(string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason));
    }

    void IStoreListener.OnInitializeFailed(InitializationFailureReason error, string message)
    {
        throw new NotImplementedException();
    }
}
