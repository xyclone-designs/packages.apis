using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using XycloneDesigns.Apis.MunicipalMoney.Cubes;
using XycloneDesigns.Apis.MunicipalMoney.Cubes.V1;
using XycloneDesigns.Apis.MunicipalMoney.Cubes.V2;

using AgedCreditorAnalysis = XycloneDesigns.Apis.MunicipalMoney.Cubes.V1.AgedCreditorAnalysis;
using AgedCreditorAnalysisV2 = XycloneDesigns.Apis.MunicipalMoney.Cubes.V2.AgedCreditorAnalysis;
using AgedDebtorAnalysis = XycloneDesigns.Apis.MunicipalMoney.Cubes.V1.AgedDebtorAnalysis;
using AgedDebtorAnalysisV2 = XycloneDesigns.Apis.MunicipalMoney.Cubes.V2.AgedDebtorAnalysis;
using CapitalAquisition = XycloneDesigns.Apis.MunicipalMoney.Cubes.V1.CapitalAquisition;
using CapitalAquisitionV2 = XycloneDesigns.Apis.MunicipalMoney.Cubes.V2.CapitalAquisition;
using CashFlow = XycloneDesigns.Apis.MunicipalMoney.Cubes.V1.CashFlow;
using CashFlowV2 = XycloneDesigns.Apis.MunicipalMoney.Cubes.V2.CashFlow;
using IncomeAndExpenditure = XycloneDesigns.Apis.MunicipalMoney.Cubes.V1.IncomeAndExpenditure;
using IncomeAndExpenditureV2 = XycloneDesigns.Apis.MunicipalMoney.Cubes.V2.IncomeAndExpenditure;
using RepairsAndMaintenance = XycloneDesigns.Apis.MunicipalMoney.Cubes.V1.RepairsAndMaintenance;
using RepairsAndMaintenanceV2 = XycloneDesigns.Apis.MunicipalMoney.Cubes.V2.RepairsAndMaintenance;

namespace XycloneDesigns.Apis._Tests.MunicipalMoney
{
	public class GlobalsMunicipalMoney
	{
		public static readonly string Directory = Path.Combine(Globals.Directory, "MunicipalMoney");
		public static readonly string Directory_Datas = Path.Combine(Directory, "datas");

		public static IEnumerable<string> CubeNames => new string[]
		{
			Cube.Names.AgedCreditorAnalysis,
			Cube.Names.AgedCreditorAnalysisV2,
			Cube.Names.AgedDebtorAnalysis,
			Cube.Names.AgedDebtorAnalysisV2,
			Cube.Names.AuditOpinions,
			Cube.Names.BalanceSheet,
			Cube.Names.CapitalAquisition,
			Cube.Names.CapitalAquisitionV2,
			Cube.Names.CashFlow,
			Cube.Names.CashFlowV2,
			Cube.Names.ConditionalGrants,
			Cube.Names.DemarcationChanges,
			Cube.Names.FinancialPositionV2,
			Cube.Names.GrantsV2,
			Cube.Names.IncomeAndExpenditure,
			Cube.Names.IncomeAndExpenditureV2,
			Cube.Names.Municipalities,
			Cube.Names.RepairsAndMaintenance,
			Cube.Names.RepairsAndMaintenanceV2,
			Cube.Names.UnauthorisedIrregularFruitlessAndWastefulExpenditure,
		};

		public static readonly IEnumerable<string[]> CubeNamesDemarcated = CubeNames.Select(_ => _ switch
		{
			Cube.Names.AgedCreditorAnalysis => AgedCreditorAnalysis.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),
			Cube.Names.AgedCreditorAnalysisV2 => AgedCreditorAnalysisV2.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),
			Cube.Names.AgedDebtorAnalysis => AgedDebtorAnalysis.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),
			Cube.Names.AgedDebtorAnalysisV2 => AgedDebtorAnalysisV2.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),
			Cube.Names.AuditOpinions => AuditOpinions.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),
			Cube.Names.BalanceSheet => BalanceSheet.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),
			Cube.Names.CapitalAquisition => CapitalAquisition.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),
			Cube.Names.CapitalAquisitionV2 => CapitalAquisitionV2.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),
			Cube.Names.CashFlow => CashFlow.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),
			Cube.Names.CashFlowV2 => CashFlowV2.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),
			Cube.Names.ConditionalGrants => ConditionalGrants.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),
			Cube.Names.DemarcationChanges => DemarcationChanges.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),
			Cube.Names.FinancialPositionV2 => FinancialPosition.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),
			Cube.Names.GrantsV2 => Grants.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),
			Cube.Names.IncomeAndExpenditure => IncomeAndExpenditure.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),
			Cube.Names.IncomeAndExpenditureV2 => IncomeAndExpenditureV2.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),
			Cube.Names.Municipalities => Municipalities.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),
			Cube.Names.RepairsAndMaintenance => RepairsAndMaintenance.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),
			Cube.Names.RepairsAndMaintenanceV2 => RepairsAndMaintenanceV2.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),
			Cube.Names.UnauthorisedIrregularFruitlessAndWastefulExpenditure => UIFWExpenditure.KeysEnumerable.SelectMany(__ => new string[] { _, __ }).ToArray(),

			_ => throw new Exception(),
		});
	}
}