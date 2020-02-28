<%@ Page Language="C#" MasterPageFile="~/MasterPages/ListView.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="HK100000.aspx.cs" Inherits="Page_HK100000" Title="Untitled Page" %>
<%@ MasterType VirtualPath="~/MasterPages/ListView.master" %>

<asp:Content ID="cont1" ContentPlaceHolderID="phDS" runat="Server">
	<px:PXDataSource ID="ds" Width="100%" runat="server" Visible = "True" PrimaryView="readings" TypeName="Hackathon20.DeviceTempEntry" >
		<CallbackCommands>
			<px:PXDSCallbackCommand Name="Save" CommitChanges="True" />
		</CallbackCommands>
	</px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" ContentPlaceHolderID="phL" runat="Server">
	<px:PXGrid ID="grid" runat="server" Height="400px" Width="100%" AllowPaging="True" AllowSearch="true" AdjustPageSize="Auto" DataSourceID="ds" SkinID="Primary">
		<Levels>
			<px:PXGridLevel DataMember="readings">
                <RowTemplate>
                    <px:PXLayoutRule runat="server" StartColumn="True"  LabelsWidth="M" ControlSize="XM" />
                    <px:PXDateTimeEdit DataField="CreatedDateTime" ID="edDate" runat="server"  />
                    <px:PXDateTimeEdit DataField="CreatedDateTime" DisplayFormat="t" ID="edTime" runat="server"/>  
                        <px:PXTextEdit ID="edRefNbr" runat="server" DataField="RefNbr"  />
                        <px:PXTextEdit ID="edDeviceID" runat="server" AllowNull="False" DataField="DeviceID" MaxLength="30"  />
                        <px:PXNumberEdit ID="edTemp" runat="server" AllowNull="False" DataField="Temperature" />
                        <px:PXNumberEdit ID="edHumidity" runat="server" DataField="Humidity"  />
                </RowTemplate>
                <Columns>
                    <px:PXGridColumn DataField="CreatedDateTime" Label="Date" />
                    <px:PXGridColumn DataField="CreatedDateTime" TimeMode="true" Label="Time"/>
                    <px:PXGridColumn DataField="RefNbr" Width="90px" />
                    <px:PXGridColumn AllowNull="False" DataField="DeviceID" MaxLength="30" Width="180px" />
                    <px:PXGridColumn AllowNull="False" DataField="Temperature"   Width="80px" />
                    <px:PXGridColumn AllowNull="False" DataField="Humidity" TextAlign="Right" Width="117px" />
                </Columns>
			</px:PXGridLevel>
		</Levels>
		<AutoSize Container="Window" Enabled="True" MinHeight="200" />
		<ActionBar ActionsText="False">
		</ActionBar>
    </px:PXGrid>
</asp:Content>
