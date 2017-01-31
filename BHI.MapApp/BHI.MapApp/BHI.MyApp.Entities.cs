using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BHI.MapApp
{
    public class BHI
    {

        public class Brand
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class SchoolDistrict
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Community
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class City
        {
            public int Count { get; set; }
            public int Key { get; set; }
            public string Value { get; set; }
            public string State { get; set; }
        }

        public class PostalCode
        {
            public int Count { get; set; }
            public int Key { get; set; }
            public string Value { get; set; }
            public string State { get; set; }
        }

        public class County
        {
            public int Count { get; set; }
            public int Key { get; set; }
            public string Value { get; set; }
            public string State { get; set; }
        }

        public class Facets
        {
            public int Sf { get; set; }
            public int Mf { get; set; }
            public int Pool { get; set; }
            public int Green { get; set; }
            public int Golf { get; set; }
            public int Gated { get; set; }
            public int Nature { get; set; }
            public int Parks { get; set; }
            public int Views { get; set; }
            public int WaterFront { get; set; }
            public int Sports { get; set; }
            public int Adult { get; set; }
            public string PrRange { get; set; }
            public string BrRange { get; set; }
            public string BaRange { get; set; }
            public string SftRange { get; set; }
            public int Custom { get; set; }
            public int Boyl { get; set; }
            public int Manufactured { get; set; }
            public List<Brand> Brands { get; set; }
            public List<SchoolDistrict> SchoolDistricts { get; set; }
            public List<Community> Communities { get; set; }
            public List<City> Cities { get; set; }
            public List<PostalCode> PostalCodes { get; set; }
            public List<County> County { get; set; }
        }

        public class ResultCounts
        {
            public int CommCount { get; set; }
            public int PaidCommCount { get; set; }
            public int NbyCommCount { get; set; }
            public int PaidNbyCommCount { get; set; }
            public int HotDealsCount { get; set; }
            public int QmiCount { get; set; }
            public int HomeCount { get; set; }
            public int CommAllHomeCount { get; set; }
            public int CommAllLuxuryCount { get; set; }
            public int BlCount { get; set; }
            public int BoylCommCount { get; set; }
            public int BoylHomeCount { get; set; }
            public Facets Facets { get; set; }
            public int Radius { get; set; }
        }

        public class SchoolDistrict2
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public object DistrictName { get; set; }
        }

        public class Brand2
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Logo { get; set; }
            public string LogoSmall { get; set; }
            public int MarketId { get; set; }
            public object State { get; set; }
            public string SiteUrl { get; set; }
        }

        public class Result
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public object Desc { get; set; }
            public string Lat { get; set; }
            public string Lng { get; set; }
            public int BuilderId { get; set; }
            public int MarketId { get; set; }
            public int ParentId { get; set; }
            public int BrLo { get; set; }
            public int BrHi { get; set; }
            public int BaLo { get; set; }
            public int BaHi { get; set; }
            public int HBaLo { get; set; }
            public int HBaHi { get; set; }
            public string SftLo { get; set; }
            public string SftHi { get; set; }
            public string PrLo { get; set; }
            public string PrHi { get; set; }
            public object Addr { get; set; }
            public string City { get; set; }
            public string County { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string Thumb1 { get; set; }
            public string Thumb2 { get; set; }
            public object Thumb3 { get; set; }
            public string Status { get; set; }
            public int NumHomes { get; set; }
            public int NumQmi { get; set; }
            public int NumQmiDone { get; set; }
            public string Phone { get; set; }
            public List<SchoolDistrict2> SchoolDistricts { get; set; }
            public Brand2 Brand { get; set; }
            public int HasHotHomes { get; set; }
            public int HasModelHome { get; set; }
            public int IsGreen { get; set; }
            public int IsUrban { get; set; }
            public int IsGated { get; set; }
            public int IsAdult { get; set; }
            public int Nature { get; set; }
            public int Pool { get; set; }
            public int Views { get; set; }
            public int Golf { get; set; }
            public int WaterFront { get; set; }
            public int Sports { get; set; }
            public int Parks { get; set; }
            public int IsCondo { get; set; }
            public int IsTownHome { get; set; }
            public int IsAgeRest { get; set; }
            public int Promo { get; set; }
            public int AgtPromo { get; set; }
            public int HasEvent { get; set; }
            public int HasVideo { get; set; }
            public double Dist { get; set; }
            public int IsBasic { get; set; }
            public int BuilderCount { get; set; }
            public string CommunityType { get; set; }
            public string ProjectType { get; set; }
            public object MarketingHeadline { get; set; }
            public object CommunityUrl { get; set; }
            public bool ShowDevNm { get; set; }
            public bool IsBoyl { get; set; }
            public bool IsCustom { get; set; }
            public bool IsManufactured { get; set; }
            public int NumModelsHomes { get; set; }
            public int ModelHomes { get; set; }
            public int PlansCount { get; set; }
            public int CompleteCount { get; set; }
            public int UnderConstruction { get; set; }
            public string Pr { get; set; }
        }

        public class RootObject
        {
            public ResultCounts ResultCounts { get; set; }
            public string SearchType { get; set; }
            public string Time { get; set; }
            public string Status { get; set; }
            public string Server { get; set; }
            public List<Result> Result { get; set; }
        }

    }
}