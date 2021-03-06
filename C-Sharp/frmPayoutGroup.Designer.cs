using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using DpSdkEngLib;
using DPSDKOPSLib;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
namespace _4PosBackOffice.NET
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class frmPayoutGroup
	{
		#region "Windows Form Designer generated code "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmPayoutGroup() : base()
		{
			FormClosed += frmPayoutGroup_FormClosed;
			KeyPress += frmPayoutGroup_KeyPress;
			Resize += frmPayoutGroup_Resize;
			Load += frmPayoutGroup_Load;
			//This call is required by the Windows Form Designer.
			InitializeComponent();
		}
//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool Disposing)
		{
			if (Disposing) {
				if ((components != null)) {
					components.Dispose();
				}
			}
			base.Dispose(Disposing);
		}
//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.CheckBox _chkFields_1;
		private System.Windows.Forms.TextBox withEventsField__txtFields_0;
		public System.Windows.Forms.TextBox _txtFields_0 {
			get { return withEventsField__txtFields_0; }
			set {
				if (withEventsField__txtFields_0 != null) {
					withEventsField__txtFields_0.Enter -= txtFields_Enter;
				}
				withEventsField__txtFields_0 = value;
				if (withEventsField__txtFields_0 != null) {
					withEventsField__txtFields_0.Enter += txtFields_Enter;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_cmdCancel;
		public System.Windows.Forms.Button cmdCancel {
			get { return withEventsField_cmdCancel; }
			set {
				if (withEventsField_cmdCancel != null) {
					withEventsField_cmdCancel.Click -= cmdCancel_Click;
				}
				withEventsField_cmdCancel = value;
				if (withEventsField_cmdCancel != null) {
					withEventsField_cmdCancel.Click += cmdCancel_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_cmdClose;
		public System.Windows.Forms.Button cmdClose {
			get { return withEventsField_cmdClose; }
			set {
				if (withEventsField_cmdClose != null) {
					withEventsField_cmdClose.Click -= cmdClose_Click;
				}
				withEventsField_cmdClose = value;
				if (withEventsField_cmdClose != null) {
					withEventsField_cmdClose.Click += cmdClose_Click;
				}
			}
		}
		public System.Windows.Forms.Panel picButtons;
		public System.Windows.Forms.Label _lblLabels_38;
		public Microsoft.VisualBasic.PowerPacks.RectangleShape _Shape1_2;
		public System.Windows.Forms.Label _lbl_5;
		//Public WithEvents chkFields As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
		//Public WithEvents lbl As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
		//Public WithEvents lblLabels As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
		//Public WithEvents txtFields As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
		public RectangleShapeArray Shape1;
		public Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
//NOTE: The following procedure is required by the Windows Form Designer
//It can be modified using the Windows Form Designer.
//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmPayoutGroup));
			this.components = new System.ComponentModel.Container();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(components);
			this.ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this._chkFields_1 = new System.Windows.Forms.CheckBox();
			this._txtFields_0 = new System.Windows.Forms.TextBox();
			this.picButtons = new System.Windows.Forms.Panel();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.cmdClose = new System.Windows.Forms.Button();
			this._lblLabels_38 = new System.Windows.Forms.Label();
			this._Shape1_2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this._lbl_5 = new System.Windows.Forms.Label();
			//Me.chkFields = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(components)
			//Me.lbl = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
			//Me.lblLabels = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
			//Me.txtFields = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
			this.Shape1 = new RectangleShapeArray(components);
			this.picButtons.SuspendLayout();
			this.SuspendLayout();
			this.ToolTip1.Active = true;
			//CType(Me.chkFields, System.ComponentModel.ISupportInitialize).BeginInit()
			//CType(Me.lbl, System.ComponentModel.ISupportInitialize).BeginInit()
			//CType(Me.lblLabels, System.ComponentModel.ISupportInitialize).BeginInit()
			//CType(Me.txtFields, System.ComponentModel.ISupportInitialize).BeginInit()
			((System.ComponentModel.ISupportInitialize)this.Shape1).BeginInit();
			this.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Text = "Edit Payout Reasons";
			this.ClientSize = new System.Drawing.Size(527, 117);
			this.Location = new System.Drawing.Point(73, 22);
			this.ControlBox = false;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Enabled = true;
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = true;
			this.HelpButton = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.Name = "frmPayoutGroup";
			this._chkFields_1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this._chkFields_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._chkFields_1.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
			this._chkFields_1.Text = "Disable this Payout Reason";
			this._chkFields_1.ForeColor = System.Drawing.SystemColors.WindowText;
			this._chkFields_1.Size = new System.Drawing.Size(155, 13);
			this._chkFields_1.Location = new System.Drawing.Point(344, 90);
			this._chkFields_1.TabIndex = 6;
			this._chkFields_1.CausesValidation = true;
			this._chkFields_1.Enabled = true;
			this._chkFields_1.Cursor = System.Windows.Forms.Cursors.Default;
			this._chkFields_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chkFields_1.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chkFields_1.TabStop = true;
			this._chkFields_1.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chkFields_1.Visible = true;
			this._chkFields_1.Name = "_chkFields_1";
			this._txtFields_0.AutoSize = false;
			this._txtFields_0.Size = new System.Drawing.Size(375, 19);
			this._txtFields_0.Location = new System.Drawing.Point(126, 66);
			this._txtFields_0.TabIndex = 5;
			this._txtFields_0.AcceptsReturn = true;
			this._txtFields_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this._txtFields_0.BackColor = System.Drawing.SystemColors.Window;
			this._txtFields_0.CausesValidation = true;
			this._txtFields_0.Enabled = true;
			this._txtFields_0.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtFields_0.HideSelection = true;
			this._txtFields_0.ReadOnly = false;
			this._txtFields_0.MaxLength = 0;
			this._txtFields_0.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtFields_0.Multiline = false;
			this._txtFields_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtFields_0.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this._txtFields_0.TabStop = true;
			this._txtFields_0.Visible = true;
			this._txtFields_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._txtFields_0.Name = "_txtFields_0";
			this.picButtons.Dock = System.Windows.Forms.DockStyle.Top;
			this.picButtons.BackColor = System.Drawing.Color.Blue;
			this.picButtons.Size = new System.Drawing.Size(527, 39);
			this.picButtons.Location = new System.Drawing.Point(0, 0);
			this.picButtons.TabIndex = 2;
			this.picButtons.TabStop = false;
			this.picButtons.CausesValidation = true;
			this.picButtons.Enabled = true;
			this.picButtons.ForeColor = System.Drawing.SystemColors.ControlText;
			this.picButtons.Cursor = System.Windows.Forms.Cursors.Default;
			this.picButtons.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.picButtons.Visible = true;
			this.picButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picButtons.Name = "picButtons";
			this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.cmdCancel.Text = "&Undo";
			this.cmdCancel.Size = new System.Drawing.Size(73, 29);
			this.cmdCancel.Location = new System.Drawing.Point(5, 3);
			this.cmdCancel.TabIndex = 1;
			this.cmdCancel.TabStop = false;
			this.cmdCancel.BackColor = System.Drawing.SystemColors.Control;
			this.cmdCancel.CausesValidation = true;
			this.cmdCancel.Enabled = true;
			this.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdCancel.Name = "cmdCancel";
			this.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.cmdClose.Text = "E&xit";
			this.cmdClose.Size = new System.Drawing.Size(73, 29);
			this.cmdClose.Location = new System.Drawing.Point(441, 4);
			this.cmdClose.TabIndex = 0;
			this.cmdClose.TabStop = false;
			this.cmdClose.BackColor = System.Drawing.SystemColors.Control;
			this.cmdClose.CausesValidation = true;
			this.cmdClose.Enabled = true;
			this.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdClose.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdClose.Name = "cmdClose";
			this._lblLabels_38.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this._lblLabels_38.Text = "Payout Reason :";
			this._lblLabels_38.Size = new System.Drawing.Size(79, 13);
			this._lblLabels_38.Location = new System.Drawing.Point(42, 69);
			this._lblLabels_38.TabIndex = 4;
			this._lblLabels_38.BackColor = System.Drawing.Color.Transparent;
			this._lblLabels_38.Enabled = true;
			this._lblLabels_38.ForeColor = System.Drawing.SystemColors.ControlText;
			this._lblLabels_38.Cursor = System.Windows.Forms.Cursors.Default;
			this._lblLabels_38.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lblLabels_38.UseMnemonic = true;
			this._lblLabels_38.Visible = true;
			this._lblLabels_38.AutoSize = true;
			this._lblLabels_38.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._lblLabels_38.Name = "_lblLabels_38";
			this._Shape1_2.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
			this._Shape1_2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this._Shape1_2.Size = new System.Drawing.Size(502, 49);
			this._Shape1_2.Location = new System.Drawing.Point(15, 60);
			this._Shape1_2.BorderColor = System.Drawing.SystemColors.WindowText;
			this._Shape1_2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
			this._Shape1_2.BorderWidth = 1;
			this._Shape1_2.FillColor = System.Drawing.Color.Black;
			this._Shape1_2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent;
			this._Shape1_2.Visible = true;
			this._Shape1_2.Name = "_Shape1_2";
			this._lbl_5.BackColor = System.Drawing.Color.Transparent;
			this._lbl_5.Text = "&1. General";
			this._lbl_5.Size = new System.Drawing.Size(60, 13);
			this._lbl_5.Location = new System.Drawing.Point(15, 45);
			this._lbl_5.TabIndex = 3;
			this._lbl_5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this._lbl_5.Enabled = true;
			this._lbl_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this._lbl_5.Cursor = System.Windows.Forms.Cursors.Default;
			this._lbl_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbl_5.UseMnemonic = true;
			this._lbl_5.Visible = true;
			this._lbl_5.AutoSize = true;
			this._lbl_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._lbl_5.Name = "_lbl_5";
			this.Controls.Add(_chkFields_1);
			this.Controls.Add(_txtFields_0);
			this.Controls.Add(picButtons);
			this.Controls.Add(_lblLabels_38);
			this.ShapeContainer1.Shapes.Add(_Shape1_2);
			this.Controls.Add(_lbl_5);
			this.Controls.Add(ShapeContainer1);
			this.picButtons.Controls.Add(cmdCancel);
			this.picButtons.Controls.Add(cmdClose);
			//Me.chkFields.SetIndex(_chkFields_1, CType(1, Short))
			//Me.lbl.SetIndex(_lbl_5, CType(5, Short))
			//Me.lblLabels.SetIndex(_lblLabels_38, CType(38, Short))
			//Me.txtFields.SetIndex(_txtFields_0, CType(0, Short))
			this.Shape1.SetIndex(_Shape1_2, Convert.ToInt16(2));
			((System.ComponentModel.ISupportInitialize)this.Shape1).EndInit();
			//CType(Me.txtFields, System.ComponentModel.ISupportInitialize).EndInit()
			//CType(Me.lblLabels, System.ComponentModel.ISupportInitialize).EndInit()
			//CType(Me.lbl, System.ComponentModel.ISupportInitialize).EndInit()
			//CType(Me.chkFields, System.ComponentModel.ISupportInitialize).EndInit()
			this.picButtons.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		#endregion
	}
}
