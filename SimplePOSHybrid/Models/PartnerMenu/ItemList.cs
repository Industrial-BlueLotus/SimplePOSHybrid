

namespace SimplePOSHybrid.Models.PartnerMenu
{


    public class ItemList
    {
        public Menuitemlist[] MenuItemList { get; set; }
    }

    public class Menuitemlist
    {
        public string ItemImage { get; set; }
        public string ItemImageUrl { get; set; }
        public string ItemName { get; set; }
        public int ItemKey { get; set; }
        public string ItemCode { get; set; }
        public string ItemShortName { get; set; }
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
        public object EAN { get; set; }
        public string Description { get; set; }
        public object ItemUnit { get; set; }
        public object ServiceUnit { get; set; }
        public object Remarks { get; set; }
        public float CostPrice { get; set; }
        public float SalesPrice { get; set; }
        public float OptionalSalesPrice { get; set; }
        public bool IsModifierItem { get; set; }
        public bool IsCompositeItem { get; set; }
        public bool IsPayemntType { get; set; }
        public float MaximumDiscount { get; set; }
        public float VatPercentage { get; set; }
        public bool IsDiscontinued { get; set; }
        public bool IsAgeVerification { get; set; }
        public bool IsPartnerItem { get; set; }
        public bool IsAvailableInPartnerSide { get; set; }
        public object ParentItem { get; set; }
        public object Brand { get; set; }
        public DateTime ExpireDate { get; set; }
        public int ValueForProjectKey { get; set; }
        public int FoodTypeId { get; set; }
        public string FoodTypeName { get; set; }
        public int UrbanPiperFoodTypeId { get; set; }
        public bool IsRecommended { get; set; }
        public float SupplierWarranty { get; set; }
        public float CustomerWarranty { get; set; }
        public float AvailableQuantity { get; set; }
        public int PartnerId { get; set; }
        public string ItemComboTitle { get; set; }
        public object PartNumber { get; set; }
        public bool IsSerialNumber { get; set; }
        public float ReOrderLevel { get; set; }
        public float ReOrderQuantity { get; set; }
        public int SortingOrder { get; set; }
        public object[] itemOrderTypes { get; set; }
        public object[] itemAllergens { get; set; }
        public Productgroup[] productGroups { get; set; }
        public Productgroupsitem[] productGroupsItem { get; set; }
    }

    public class Productgroup
    {
        public int ProductGroupId { get; set; }
        public string GroupName { get; set; }
        public int GroupNo { get; set; }
        public object[] GrupedProducts { get; set; }
        public object Company { get; set; }
        public string ProductItemCode { get; set; }
        public float Price { get; set; }
        public int UrbanPiperFoodType { get; set; }
        public float MinumumQuantity { get; set; }
        public float MaximumQuantity { get; set; }
        public object[] NestedGroups { get; set; }
        public object IntegrationId { get; set; }
        public object RequestingId { get; set; }
        public object Apikey { get; set; }
        public bool IsAllowedForTransaction { get; set; }
        public bool IsAllowedForPrinting { get; set; }
        public int RequestingObjectKey { get; set; }
        public int PersitingObjectKey { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int ApproveSate { get; set; }
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; }
        public bool IsDefault { get; set; }
        public object CreatedBy { get; set; }
        public object UpdatedBy { get; set; }
        public object IsActiveStr { get; set; }
        public object OwningCompany { get; set; }
        public bool IsRecordLocked { get; set; }
    }

    public class Productgroupsitem
    {
        public int ProductGroupId { get; set; }
        public string GroupName { get; set; }
        public int GroupNo { get; set; }
        public object[] GrupedProducts { get; set; }
        public object Company { get; set; }
        public string ProductItemCode { get; set; }
        public float Price { get; set; }
        public int UrbanPiperFoodType { get; set; }
        public float MinumumQuantity { get; set; }
        public float MaximumQuantity { get; set; }
        public Nestedgroup[] NestedGroups { get; set; }
        public object IntegrationId { get; set; }
        public object RequestingId { get; set; }
        public object Apikey { get; set; }
        public bool IsAllowedForTransaction { get; set; }
        public bool IsAllowedForPrinting { get; set; }
        public int RequestingObjectKey { get; set; }
        public int PersitingObjectKey { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int ApproveSate { get; set; }
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; }
        public bool IsDefault { get; set; }
        public object CreatedBy { get; set; }
        public object UpdatedBy { get; set; }
        public object IsActiveStr { get; set; }
        public object OwningCompany { get; set; }
        public bool IsRecordLocked { get; set; }
    }

    public class Nestedgroup
    {
        public int ProductGroupId { get; set; }
        public string GroupName { get; set; }
        public int GroupNo { get; set; }
        public object[] GrupedProducts { get; set; }
        public object Company { get; set; }
        public object ProductItemCode { get; set; }
        public float Price { get; set; }
        public int UrbanPiperFoodType { get; set; }
        public float MinumumQuantity { get; set; }
        public float MaximumQuantity { get; set; }
        public object[] NestedGroups { get; set; }
        public object IntegrationId { get; set; }
        public object RequestingId { get; set; }
        public object Apikey { get; set; }
        public bool IsAllowedForTransaction { get; set; }
        public bool IsAllowedForPrinting { get; set; }
        public int RequestingObjectKey { get; set; }
        public int PersitingObjectKey { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int ApproveSate { get; set; }
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; }
        public bool IsDefault { get; set; }
        public object CreatedBy { get; set; }
        public object UpdatedBy { get; set; }
        public object IsActiveStr { get; set; }
        public object OwningCompany { get; set; }
        public bool IsRecordLocked { get; set; }
    }


}
