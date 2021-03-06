Imports Microsoft.VisualBasic
Imports System.Web.Routing
Imports DevExpress.DashboardWeb
Imports DevExpress.DashboardWeb.Mvc

Namespace MvcThrowCustomExceptionDashboardErrorToast
	Public Class DashboardConfig
		Public Shared Sub RegisterService(ByVal routes As RouteCollection)
			'routes.MapDashboardRoute();

			' Uncomment this line to save dashboards to the App_Data folder.
			'DashboardConfigurator.Default.SetDashboardStorage(new DashboardFileStorage(@"~/App_Data/"));

			' Uncomment these lines to create an in-memory storage of dashboard data sources. Use the DataSourceInMemoryStorage.RegisterDataSource
			' method to register the existing data source in the created storage.
			'var dataSourceStorage = new DataSourceInMemoryStorage();
			'DashboardConfigurator.Default.SetDataSourceStorage(dataSourceStorage);


			routes.MapDashboardRoute("dashboardDesigner", "CustomDashboard", New String() { "MvcThrowCustomExceptionDashboardErrorToast" })
		End Sub
	End Class
End Namespace