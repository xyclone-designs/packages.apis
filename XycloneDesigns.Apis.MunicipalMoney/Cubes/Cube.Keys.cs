
namespace XycloneDesigns.Apis.MunicipalMoney.Cubes
{
	public partial class Cube 
	{
		public class Keys
		{
			public class AmountType
			{
				public const string Code = "amount_type.code";
				public const string Label = "amount_type.label";
			}
			public class ContactDetails
			{
				public const string EmailAddress = "contact_details.email_address";
				public const string FaxNumber = "contact_details.fax_number";
				public const string Name = "contact_details.name";
				public const string PhoneNumber = "contact_details.phone_number";
				public const string Title = "contact_details.title";
			}
			public class CustomerGroup
			{
				public const string Code = "customer_group.code";
			}
			public class CapitalType
			{
				public const string Code = "capital_type.code";
				public const string Label = "capital_type.label";
			}
			public class Dates
			{
				public const string Date = "date.date";
			}
			public class Demarcation
			{
				public const string Code = "demarcation.code";
				public const string CodeNew = "new_demarcation.code";
				public const string CodeOld = "old_demarcation.code";
				public const string CodeTransitionNew = "new_code_transition.code";
				public const string CodeTransitionOld = "old_code_transition.code";
				public const string Label = "demarcation.label";
			}
			public class FinancialPeriod
			{
				public const string Period = "financial_period.period";
			}
			public class FinancialYearEnd
			{
				public const string Year = "financial_year_end.year";
			}
			public class Function
			{
				public const string CategoryLabel = "function.category_label";
				public const string Code = "function.code";
				public const string Label = "function.label";
				public const string SubcategoryLabel = "function.subcategory_label";
			}
			public class Grant
			{
				public const string Code = "grant.code";
				public const string Label = "grant.label";
			}
			public class Item
			{
				public const string Code = "item.code";
				public const string Composition = "item.composition";
				public const string Label = "item.label";
				public const string PositionInReturnForm = "item.position_in_return_form";
				public const string ReturnFormStructure = "item.return_form_structure";
			}
			public class Municipality
			{
				public const string Category = "municipality.category";
				public const string DemarcationCode = "municipality.demarcation_code";
				public const string FaxNumber = "municipality.fax_number";
				public const string LongName = "municipality.long_name";
				public const string MIIFCategory = "municipality.miif_category";
				public const string Name = "municipality.name";
				public const string ParentMunicipalityCode = "municipality.parent_code";
				public const string PhoneNumber = "municipality.phone_number";
				public const string PostalAddressPart1 = "municipality.postal_address_1";   
				public const string PostalAddressPart2 = "municipality.postal_address_2";   
				public const string PostalAddressPart3 = "municipality.postal_address_3";
				public const string ProvinceCode = "municipality.province_code";
				public const string ProvinceName = "municipality.province_name";
				public const string StreetAddressPart1 = "municipality.street_address_1";   
				public const string StreetAddressPart2 = "municipality.street_address_2";   
				public const string StreetAddressPart3 = "municipality.street_address_3";   
				public const string StreetAddressPart4 = "municipality.street_address_4";
				public const string Url = "municipality.url";
			}
			public class Opinion
			{
				public const string AuditorGeneralsReportURL = "opinion.report_url";
				public const string Code = "opinion.code";
				public const string Label = "opinion.label";
			}
			public class PeriodLength
			{
				public const string Length = "period_length.length";
			}
			public class Roles
			{
				public const string Role = "role.role";
			}
		}
	}
}