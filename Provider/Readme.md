Update Global.asax
Add AreaRegistration.RegisterAllAreas(); under Application_Start() if it does not exist
If you have a project standard layout, create a new or copy the project's _ViewStart.cshtml file.
All ActionLinks should have this format to link to controllers in areas:
	@Html.ActionLink("LinkName", "ControllerMethod", "ControllerName", new { area = "AreaName" }, new { })
If you link to controllers that are not in an area from an area view, use new { area = "" } as the parameter