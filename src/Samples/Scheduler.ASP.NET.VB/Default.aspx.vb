﻿Imports DHTMLX.Scheduler
Imports DHTMLX.Scheduler.Controls

Public Class _Default
    Inherits System.Web.UI.Page

    Public Scheduler As DHXScheduler

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Scheduler = New DHXScheduler()
        Scheduler.Skin = DHXScheduler.Skins.Material
        Scheduler.InitialDate = new DateTime(2017, 11, 24)
        Scheduler.Config.first_hour = 8
        Scheduler.Config.last_hour = 19
        Scheduler.Config.time_step = 30

        Scheduler.Config.limit_time_select = True
        Scheduler.DataAction = Me.ResolveUrl("~/Data.ashx")
        Scheduler.SaveAction = Me.ResolveUrl("~/Save.ashx")
        Scheduler.LoadData = True
        Scheduler.EnableDataprocessor = True

    End Sub

End Class