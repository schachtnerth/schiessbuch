﻿using schiessbuch;
using schiessbuch.siusclubDataSetTableAdapters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace schiessbuch
{
    partial class Schiessbuch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label vereinLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schiessbuch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle73 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle78 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle79 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle74 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle75 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle76 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle77 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle84 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle85 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle80 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle81 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle82 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle83 = new System.Windows.Forms.DataGridViewCellStyle();
            this.schuetzenListeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siusclubDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siusclubDataSet = new schiessbuch.siusclubDataSet();
            this.schuetzenListeBindingSourceA = new System.Windows.Forms.BindingSource(this.components);
            this.schiessbuchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schuetzenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SchiessbuchContexMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.disziplinkorrigierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.eintratgültigSetzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.auswertenEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.schuetzenlisteschiessbuchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trefferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schiessbuchtrefferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.schießjahrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesSchießjahrBeginnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schießjahrAuswählenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitungsmodusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordnerFürSicherungenFestlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pfadZuMysqldumpFestlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vereinsmeisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jahresübersichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.uebersichtgemeindemeisterschaftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gemeindemeisterschaftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gemeindemeisterschaft = new schiessbuch.gemeindemeisterschaft();
            this.tabGemeindemeisterschaft = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.cbDatumFiltern = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbVereineFiltern = new System.Windows.Forms.CheckBox();
            this.comboDatumFiltern = new System.Windows.Forms.ComboBox();
            this.datumlisteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboVereineFiltern = new System.Windows.Forms.ComboBox();
            this.vereinslisteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGmmDruck = new System.Windows.Forms.Button();
            this.gmmDGV = new System.Windows.Forms.DataGridView();
            this.vereinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gemeindemeisterLuftgewehrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gemeindemeisterLuftpistoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gemeindemeisterLuftgewehrAuflageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gemeindemeisterLuftpistoleAuflageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preisLuftgewehrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preisLuftpistoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preisLuftgewehrAuflageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preisLuftpistoleAuflageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bürgermeisterpokalLuftgewehrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bürgermeisterpokalLuftpistoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bürgermeisterpokalLuftgewehrAuflageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bürgermeisterpokalLuftpistoleAuflageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gedächtnispokalLuftgewehrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gedächtnispokalLuftpistoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gedächtnispokalLuftgewehrAuflageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gedächtnispokalLuftpistoleAuflageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schiessjahrIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schuetzeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uebersichtgemeindemeisterschaftBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.vereinsheimSiusclubDataSet2 = new schiessbuch.VereinsheimSiusclubDataSet2();
            this.tabEinzelscheibe = new System.Windows.Forms.TabPage();
            this.pictureBoxEinzelScheibe = new System.Windows.Forms.PictureBox();
            this.tabStandUebersicht = new System.Windows.Forms.TabPage();
            this.UebersichtTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Stand1SplitContainer = new System.Windows.Forms.SplitContainer();
            this.stand1Zielscheibe = new System.Windows.Forms.PictureBox();
            this.lblProbe1 = new System.Windows.Forms.Label();
            this.txtSchussStand1 = new System.Windows.Forms.Label();
            this.lblSchussStand1 = new System.Windows.Forms.Label();
            this.txtDisziplinStand1 = new System.Windows.Forms.Label();
            this.lblDisziplinStand1 = new System.Windows.Forms.Label();
            this.txtSchuetzeStand1 = new System.Windows.Forms.Label();
            this.lblSchuetzeStand1 = new System.Windows.Forms.Label();
            this.Stand1SchussPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtSchuss100 = new System.Windows.Forms.Label();
            this.txtSchuss110 = new System.Windows.Forms.Label();
            this.txtSchuss120 = new System.Windows.Forms.Label();
            this.txtSchuss130 = new System.Windows.Forms.Label();
            this.txtSchuss140 = new System.Windows.Forms.Label();
            this.txtSchuss101 = new System.Windows.Forms.Label();
            this.txtSchuss111 = new System.Windows.Forms.Label();
            this.txtSchuss121 = new System.Windows.Forms.Label();
            this.txtSchuss131 = new System.Windows.Forms.Label();
            this.txtSchuss141 = new System.Windows.Forms.Label();
            this.txtSchuss102 = new System.Windows.Forms.Label();
            this.txtSchuss112 = new System.Windows.Forms.Label();
            this.txtSchuss122 = new System.Windows.Forms.Label();
            this.txtSchuss132 = new System.Windows.Forms.Label();
            this.txtSchuss142 = new System.Windows.Forms.Label();
            this.txtSchuss103 = new System.Windows.Forms.Label();
            this.txtSchuss113 = new System.Windows.Forms.Label();
            this.txtSchuss123 = new System.Windows.Forms.Label();
            this.txtSchuss133 = new System.Windows.Forms.Label();
            this.txtSchuss143 = new System.Windows.Forms.Label();
            this.txtSchuss104 = new System.Windows.Forms.Label();
            this.txtSchuss114 = new System.Windows.Forms.Label();
            this.txtSchuss124 = new System.Windows.Forms.Label();
            this.txtSchuss134 = new System.Windows.Forms.Label();
            this.txtSchuss144 = new System.Windows.Forms.Label();
            this.txtSchuss105 = new System.Windows.Forms.Label();
            this.txtSchuss115 = new System.Windows.Forms.Label();
            this.txtSchuss125 = new System.Windows.Forms.Label();
            this.txtSchuss135 = new System.Windows.Forms.Label();
            this.txtSchuss145 = new System.Windows.Forms.Label();
            this.txtSchuss106 = new System.Windows.Forms.Label();
            this.txtSchuss116 = new System.Windows.Forms.Label();
            this.txtSchuss126 = new System.Windows.Forms.Label();
            this.txtSchuss136 = new System.Windows.Forms.Label();
            this.txtSchuss146 = new System.Windows.Forms.Label();
            this.txtSchuss107 = new System.Windows.Forms.Label();
            this.txtSchuss117 = new System.Windows.Forms.Label();
            this.txtSchuss127 = new System.Windows.Forms.Label();
            this.txtSchuss137 = new System.Windows.Forms.Label();
            this.txtSchuss147 = new System.Windows.Forms.Label();
            this.Stand2SplitContainer = new System.Windows.Forms.SplitContainer();
            this.stand2Zielscheibe = new System.Windows.Forms.PictureBox();
            this.lblProbe2 = new System.Windows.Forms.Label();
            this.txtSchussStand2 = new System.Windows.Forms.Label();
            this.lblSchussStand2 = new System.Windows.Forms.Label();
            this.txtDisziplinStand2 = new System.Windows.Forms.Label();
            this.lblDisziplinStand2 = new System.Windows.Forms.Label();
            this.txtSchuetzeStand2 = new System.Windows.Forms.Label();
            this.lblSchuetzeStand2 = new System.Windows.Forms.Label();
            this.Stand2SchussPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtSchuss200 = new System.Windows.Forms.Label();
            this.txtSchuss210 = new System.Windows.Forms.Label();
            this.txtSchuss220 = new System.Windows.Forms.Label();
            this.txtSchuss230 = new System.Windows.Forms.Label();
            this.txtSchuss240 = new System.Windows.Forms.Label();
            this.txtSchuss201 = new System.Windows.Forms.Label();
            this.txtSchuss211 = new System.Windows.Forms.Label();
            this.txtSchuss221 = new System.Windows.Forms.Label();
            this.txtSchuss231 = new System.Windows.Forms.Label();
            this.txtSchuss241 = new System.Windows.Forms.Label();
            this.txtSchuss202 = new System.Windows.Forms.Label();
            this.txtSchuss212 = new System.Windows.Forms.Label();
            this.txtSchuss222 = new System.Windows.Forms.Label();
            this.txtSchuss232 = new System.Windows.Forms.Label();
            this.txtSchuss242 = new System.Windows.Forms.Label();
            this.txtSchuss203 = new System.Windows.Forms.Label();
            this.txtSchuss213 = new System.Windows.Forms.Label();
            this.txtSchuss223 = new System.Windows.Forms.Label();
            this.txtSchuss233 = new System.Windows.Forms.Label();
            this.txtSchuss243 = new System.Windows.Forms.Label();
            this.txtSchuss204 = new System.Windows.Forms.Label();
            this.txtSchuss214 = new System.Windows.Forms.Label();
            this.txtSchuss224 = new System.Windows.Forms.Label();
            this.txtSchuss234 = new System.Windows.Forms.Label();
            this.txtSchuss244 = new System.Windows.Forms.Label();
            this.txtSchuss205 = new System.Windows.Forms.Label();
            this.txtSchuss215 = new System.Windows.Forms.Label();
            this.txtSchuss225 = new System.Windows.Forms.Label();
            this.txtSchuss235 = new System.Windows.Forms.Label();
            this.txtSchuss245 = new System.Windows.Forms.Label();
            this.txtSchuss206 = new System.Windows.Forms.Label();
            this.txtSchuss216 = new System.Windows.Forms.Label();
            this.txtSchuss226 = new System.Windows.Forms.Label();
            this.txtSchuss236 = new System.Windows.Forms.Label();
            this.txtSchuss246 = new System.Windows.Forms.Label();
            this.txtSchuss207 = new System.Windows.Forms.Label();
            this.txtSchuss217 = new System.Windows.Forms.Label();
            this.txtSchuss227 = new System.Windows.Forms.Label();
            this.txtSchuss237 = new System.Windows.Forms.Label();
            this.txtSchuss247 = new System.Windows.Forms.Label();
            this.Stand3SplitContainer = new System.Windows.Forms.SplitContainer();
            this.stand3Zielscheibe = new System.Windows.Forms.PictureBox();
            this.lblProbe3 = new System.Windows.Forms.Label();
            this.txtSchussStand3 = new System.Windows.Forms.Label();
            this.lblSchussStand3 = new System.Windows.Forms.Label();
            this.txtDisziplinStand3 = new System.Windows.Forms.Label();
            this.lblDisziplinStand3 = new System.Windows.Forms.Label();
            this.txtSchuetzeStand3 = new System.Windows.Forms.Label();
            this.lblSchuetzeStand3 = new System.Windows.Forms.Label();
            this.Stand3SchussPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtSchuss300 = new System.Windows.Forms.Label();
            this.txtSchuss310 = new System.Windows.Forms.Label();
            this.txtSchuss320 = new System.Windows.Forms.Label();
            this.txtSchuss330 = new System.Windows.Forms.Label();
            this.txtSchuss340 = new System.Windows.Forms.Label();
            this.txtSchuss301 = new System.Windows.Forms.Label();
            this.txtSchuss311 = new System.Windows.Forms.Label();
            this.txtSchuss321 = new System.Windows.Forms.Label();
            this.txtSchuss331 = new System.Windows.Forms.Label();
            this.txtSchuss341 = new System.Windows.Forms.Label();
            this.txtSchuss302 = new System.Windows.Forms.Label();
            this.txtSchuss312 = new System.Windows.Forms.Label();
            this.txtSchuss322 = new System.Windows.Forms.Label();
            this.txtSchuss332 = new System.Windows.Forms.Label();
            this.txtSchuss342 = new System.Windows.Forms.Label();
            this.txtSchuss303 = new System.Windows.Forms.Label();
            this.txtSchuss313 = new System.Windows.Forms.Label();
            this.txtSchuss323 = new System.Windows.Forms.Label();
            this.txtSchuss333 = new System.Windows.Forms.Label();
            this.txtSchuss343 = new System.Windows.Forms.Label();
            this.txtSchuss304 = new System.Windows.Forms.Label();
            this.txtSchuss314 = new System.Windows.Forms.Label();
            this.txtSchuss324 = new System.Windows.Forms.Label();
            this.txtSchuss334 = new System.Windows.Forms.Label();
            this.txtSchuss344 = new System.Windows.Forms.Label();
            this.txtSchuss305 = new System.Windows.Forms.Label();
            this.txtSchuss315 = new System.Windows.Forms.Label();
            this.txtSchuss325 = new System.Windows.Forms.Label();
            this.txtSchuss335 = new System.Windows.Forms.Label();
            this.txtSchuss345 = new System.Windows.Forms.Label();
            this.txtSchuss306 = new System.Windows.Forms.Label();
            this.txtSchuss316 = new System.Windows.Forms.Label();
            this.txtSchuss326 = new System.Windows.Forms.Label();
            this.txtSchuss336 = new System.Windows.Forms.Label();
            this.txtSchuss346 = new System.Windows.Forms.Label();
            this.txtSchuss307 = new System.Windows.Forms.Label();
            this.txtSchuss317 = new System.Windows.Forms.Label();
            this.txtSchuss327 = new System.Windows.Forms.Label();
            this.txtSchuss337 = new System.Windows.Forms.Label();
            this.txtSchuss347 = new System.Windows.Forms.Label();
            this.Stand6SplitContainer = new System.Windows.Forms.SplitContainer();
            this.stand6Zielscheibe = new System.Windows.Forms.PictureBox();
            this.lblProbe6 = new System.Windows.Forms.Label();
            this.txtSchussStand6 = new System.Windows.Forms.Label();
            this.lblSchussStand6 = new System.Windows.Forms.Label();
            this.txtDisziplinStand6 = new System.Windows.Forms.Label();
            this.lblDisziplinStand6 = new System.Windows.Forms.Label();
            this.txtSchuetzeStand6 = new System.Windows.Forms.Label();
            this.lblSchuetzeStand6 = new System.Windows.Forms.Label();
            this.Stand6SchussPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtSchuss600 = new System.Windows.Forms.Label();
            this.txtSchuss610 = new System.Windows.Forms.Label();
            this.txtSchuss620 = new System.Windows.Forms.Label();
            this.txtSchuss630 = new System.Windows.Forms.Label();
            this.txtSchuss640 = new System.Windows.Forms.Label();
            this.txtSchuss601 = new System.Windows.Forms.Label();
            this.txtSchuss611 = new System.Windows.Forms.Label();
            this.txtSchuss621 = new System.Windows.Forms.Label();
            this.txtSchuss631 = new System.Windows.Forms.Label();
            this.txtSchuss641 = new System.Windows.Forms.Label();
            this.txtSchuss602 = new System.Windows.Forms.Label();
            this.txtSchuss612 = new System.Windows.Forms.Label();
            this.txtSchuss622 = new System.Windows.Forms.Label();
            this.txtSchuss632 = new System.Windows.Forms.Label();
            this.txtSchuss642 = new System.Windows.Forms.Label();
            this.txtSchuss603 = new System.Windows.Forms.Label();
            this.txtSchuss613 = new System.Windows.Forms.Label();
            this.txtSchuss623 = new System.Windows.Forms.Label();
            this.txtSchuss633 = new System.Windows.Forms.Label();
            this.txtSchuss643 = new System.Windows.Forms.Label();
            this.txtSchuss604 = new System.Windows.Forms.Label();
            this.txtSchuss614 = new System.Windows.Forms.Label();
            this.txtSchuss624 = new System.Windows.Forms.Label();
            this.txtSchuss634 = new System.Windows.Forms.Label();
            this.txtSchuss644 = new System.Windows.Forms.Label();
            this.txtSchuss605 = new System.Windows.Forms.Label();
            this.txtSchuss615 = new System.Windows.Forms.Label();
            this.txtSchuss625 = new System.Windows.Forms.Label();
            this.txtSchuss635 = new System.Windows.Forms.Label();
            this.txtSchuss645 = new System.Windows.Forms.Label();
            this.txtSchuss606 = new System.Windows.Forms.Label();
            this.txtSchuss616 = new System.Windows.Forms.Label();
            this.txtSchuss626 = new System.Windows.Forms.Label();
            this.txtSchuss636 = new System.Windows.Forms.Label();
            this.txtSchuss646 = new System.Windows.Forms.Label();
            this.txtSchuss607 = new System.Windows.Forms.Label();
            this.txtSchuss617 = new System.Windows.Forms.Label();
            this.txtSchuss627 = new System.Windows.Forms.Label();
            this.txtSchuss637 = new System.Windows.Forms.Label();
            this.txtSchuss647 = new System.Windows.Forms.Label();
            this.Stand5SplitContainer = new System.Windows.Forms.SplitContainer();
            this.stand5Zielscheibe = new System.Windows.Forms.PictureBox();
            this.lblProbe5 = new System.Windows.Forms.Label();
            this.txtSchussStand5 = new System.Windows.Forms.Label();
            this.lblSchussStand5 = new System.Windows.Forms.Label();
            this.txtDisziplinStand5 = new System.Windows.Forms.Label();
            this.lblDisziplinStand5 = new System.Windows.Forms.Label();
            this.txtSchuetzeStand5 = new System.Windows.Forms.Label();
            this.lblSchuetzeStand5 = new System.Windows.Forms.Label();
            this.Stand5SchussPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtSchuss500 = new System.Windows.Forms.Label();
            this.txtSchuss510 = new System.Windows.Forms.Label();
            this.txtSchuss520 = new System.Windows.Forms.Label();
            this.txtSchuss530 = new System.Windows.Forms.Label();
            this.txtSchuss540 = new System.Windows.Forms.Label();
            this.txtSchuss501 = new System.Windows.Forms.Label();
            this.txtSchuss511 = new System.Windows.Forms.Label();
            this.txtSchuss521 = new System.Windows.Forms.Label();
            this.txtSchuss531 = new System.Windows.Forms.Label();
            this.txtSchuss541 = new System.Windows.Forms.Label();
            this.txtSchuss502 = new System.Windows.Forms.Label();
            this.txtSchuss512 = new System.Windows.Forms.Label();
            this.txtSchuss522 = new System.Windows.Forms.Label();
            this.txtSchuss532 = new System.Windows.Forms.Label();
            this.txtSchuss542 = new System.Windows.Forms.Label();
            this.txtSchuss503 = new System.Windows.Forms.Label();
            this.txtSchuss513 = new System.Windows.Forms.Label();
            this.txtSchuss523 = new System.Windows.Forms.Label();
            this.txtSchuss533 = new System.Windows.Forms.Label();
            this.txtSchuss543 = new System.Windows.Forms.Label();
            this.txtSchuss504 = new System.Windows.Forms.Label();
            this.txtSchuss514 = new System.Windows.Forms.Label();
            this.txtSchuss524 = new System.Windows.Forms.Label();
            this.txtSchuss534 = new System.Windows.Forms.Label();
            this.txtSchuss544 = new System.Windows.Forms.Label();
            this.txtSchuss505 = new System.Windows.Forms.Label();
            this.txtSchuss515 = new System.Windows.Forms.Label();
            this.txtSchuss525 = new System.Windows.Forms.Label();
            this.txtSchuss535 = new System.Windows.Forms.Label();
            this.txtSchuss545 = new System.Windows.Forms.Label();
            this.txtSchuss506 = new System.Windows.Forms.Label();
            this.txtSchuss516 = new System.Windows.Forms.Label();
            this.txtSchuss526 = new System.Windows.Forms.Label();
            this.txtSchuss536 = new System.Windows.Forms.Label();
            this.txtSchuss546 = new System.Windows.Forms.Label();
            this.txtSchuss507 = new System.Windows.Forms.Label();
            this.txtSchuss517 = new System.Windows.Forms.Label();
            this.txtSchuss527 = new System.Windows.Forms.Label();
            this.txtSchuss537 = new System.Windows.Forms.Label();
            this.txtSchuss547 = new System.Windows.Forms.Label();
            this.Stand4SplitContainer = new System.Windows.Forms.SplitContainer();
            this.stand4Zielscheibe = new System.Windows.Forms.PictureBox();
            this.lblProbe4 = new System.Windows.Forms.Label();
            this.Stand4SchussPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtSchuss400 = new System.Windows.Forms.Label();
            this.txtSchuss410 = new System.Windows.Forms.Label();
            this.txtSchuss420 = new System.Windows.Forms.Label();
            this.txtSchuss430 = new System.Windows.Forms.Label();
            this.txtSchuss440 = new System.Windows.Forms.Label();
            this.txtSchuss401 = new System.Windows.Forms.Label();
            this.txtSchuss411 = new System.Windows.Forms.Label();
            this.txtSchuss421 = new System.Windows.Forms.Label();
            this.txtSchuss431 = new System.Windows.Forms.Label();
            this.txtSchuss441 = new System.Windows.Forms.Label();
            this.txtSchuss402 = new System.Windows.Forms.Label();
            this.txtSchuss412 = new System.Windows.Forms.Label();
            this.txtSchuss422 = new System.Windows.Forms.Label();
            this.txtSchuss432 = new System.Windows.Forms.Label();
            this.txtSchuss442 = new System.Windows.Forms.Label();
            this.txtSchuss403 = new System.Windows.Forms.Label();
            this.txtSchuss413 = new System.Windows.Forms.Label();
            this.txtSchuss423 = new System.Windows.Forms.Label();
            this.txtSchuss433 = new System.Windows.Forms.Label();
            this.txtSchuss443 = new System.Windows.Forms.Label();
            this.txtSchuss404 = new System.Windows.Forms.Label();
            this.txtSchuss414 = new System.Windows.Forms.Label();
            this.txtSchuss424 = new System.Windows.Forms.Label();
            this.txtSchuss434 = new System.Windows.Forms.Label();
            this.txtSchuss444 = new System.Windows.Forms.Label();
            this.txtSchuss405 = new System.Windows.Forms.Label();
            this.txtSchuss415 = new System.Windows.Forms.Label();
            this.txtSchuss425 = new System.Windows.Forms.Label();
            this.txtSchuss435 = new System.Windows.Forms.Label();
            this.txtSchuss445 = new System.Windows.Forms.Label();
            this.txtSchuss406 = new System.Windows.Forms.Label();
            this.txtSchuss416 = new System.Windows.Forms.Label();
            this.txtSchuss426 = new System.Windows.Forms.Label();
            this.txtSchuss436 = new System.Windows.Forms.Label();
            this.txtSchuss446 = new System.Windows.Forms.Label();
            this.txtSchuss407 = new System.Windows.Forms.Label();
            this.txtSchuss417 = new System.Windows.Forms.Label();
            this.txtSchuss427 = new System.Windows.Forms.Label();
            this.txtSchuss437 = new System.Windows.Forms.Label();
            this.txtSchuss447 = new System.Windows.Forms.Label();
            this.lblSchussStand4 = new System.Windows.Forms.Label();
            this.txtSchussStand4 = new System.Windows.Forms.Label();
            this.lblDisziplinStand4 = new System.Windows.Forms.Label();
            this.txtDisziplinStand4 = new System.Windows.Forms.Label();
            this.lblSchuetzeStand4 = new System.Windows.Forms.Label();
            this.txtSchuetzeStand4 = new System.Windows.Forms.Label();
            this.wanderpokal = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.JahrespokalErwachseneDGV = new System.Windows.Forms.DataGridView();
            this.JahrespokalJugendDGV = new System.Windows.Forms.DataGridView();
            this.labelWPSK = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelTermin2 = new System.Windows.Forms.Label();
            this.dateTimeWPTermin2 = new System.Windows.Forms.DateTimePicker();
            this.labelTermin3 = new System.Windows.Forms.Label();
            this.dateTimeWPTermin3 = new System.Windows.Forms.DateTimePicker();
            this.labelTermin4 = new System.Windows.Forms.Label();
            this.dateTimeWPTermin4 = new System.Windows.Forms.DateTimePicker();
            this.labelTermin5 = new System.Windows.Forms.Label();
            this.dateTimeWPTermin5 = new System.Windows.Forms.DateTimePicker();
            this.labelTermin6 = new System.Windows.Forms.Label();
            this.dateTimeWPTermin6 = new System.Windows.Forms.DateTimePicker();
            this.labelTermin7 = new System.Windows.Forms.Label();
            this.dateTimeWPTermin7 = new System.Windows.Forms.DateTimePicker();
            this.labelTermin8 = new System.Windows.Forms.Label();
            this.dateTimeWPTermin8 = new System.Windows.Forms.DateTimePicker();
            this.labelTermin9 = new System.Windows.Forms.Label();
            this.dateTimeWPTermin9 = new System.Windows.Forms.DateTimePicker();
            this.labelTermin10 = new System.Windows.Forms.Label();
            this.dateTimeWPTermin10 = new System.Windows.Forms.DateTimePicker();
            this.labelTermin11 = new System.Windows.Forms.Label();
            this.dateTimeWPTermin11 = new System.Windows.Forms.DateTimePicker();
            this.labelTermin12 = new System.Windows.Forms.Label();
            this.dateTimeWPTermin12 = new System.Windows.Forms.DateTimePicker();
            this.labelTermin1 = new System.Windows.Forms.Label();
            this.dateTimeWPTermin1 = new System.Windows.Forms.DateTimePicker();
            this.KoenigTab = new System.Windows.Forms.TabPage();
            this.splitContainerKoenig1 = new System.Windows.Forms.SplitContainer();
            this.splitContainerKoenig2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.SchuetzenklasseLabel = new System.Windows.Forms.Label();
            this.KoenigSKGridView = new System.Windows.Forms.DataGridView();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.SchuetzenlieslLabel = new System.Windows.Forms.Label();
            this.KoenigDKGridView = new System.Windows.Forms.DataGridView();
            this.PositionDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullnameDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeilerDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainerKoenig3 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.KoenigAuflageGridView = new System.Windows.Forms.DataGridView();
            this.PositionAuflage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullnameAuflage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumAuflage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeilerAuflage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypAuflage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.KoenigJUGGridView = new System.Windows.Forms.DataGridView();
            this.PositionJUG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullnameJUG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumJUG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeilerJUG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypJUG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagesAuswertung = new System.Windows.Forms.TabPage();
            this.btnKassenbericht = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnTagesAuswertungListeDrucken = new System.Windows.Forms.Button();
            this.btnTagesAuswertungDrucken = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Schiessabend = new System.Windows.Forms.DataGridView();
            this.AuswertungTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AuswertungLG30 = new System.Windows.Forms.TextBox();
            this.AuswertungLG20 = new System.Windows.Forms.TextBox();
            this.AuswertungLG20_15 = new System.Windows.Forms.TextBox();
            this.AuswertungLG30_15 = new System.Windows.Forms.TextBox();
            this.AuswertungLG40 = new System.Windows.Forms.TextBox();
            this.AuswertungLG40_15 = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AuswertungLG30A = new System.Windows.Forms.TextBox();
            this.AuswertungLG30A_15 = new System.Windows.Forms.TextBox();
            this.AuswertungLG40A = new System.Windows.Forms.TextBox();
            this.AuswertungLG40A_15 = new System.Windows.Forms.TextBox();
            this.AuswertungLG20A_15 = new System.Windows.Forms.TextBox();
            this.AuswertungLG20A = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.AuswertungLP30 = new System.Windows.Forms.TextBox();
            this.AuswertungLP20 = new System.Windows.Forms.TextBox();
            this.AuswertungLP20_15 = new System.Windows.Forms.TextBox();
            this.AuswertungLP30_15 = new System.Windows.Forms.TextBox();
            this.AuswertungLP40 = new System.Windows.Forms.TextBox();
            this.AuswertungLP40_15 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SchuetzeComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SchiessbuchTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KlasseName = new System.Windows.Forms.TextBox();
            this.geburtsdatumTextBox = new System.Windows.Forms.TextBox();
            this.geschlechtTextBox = new System.Windows.Forms.TextBox();
            this.lblWanderpokalschiessen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.vereinComboBox = new System.Windows.Forms.ComboBox();
            this.vereineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siusclubDataSet1 = new schiessbuch.siusclubDataSet();
            this.DoUpdates = new System.Windows.Forms.CheckBox();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.fullnameComboBox = new System.Windows.Forms.ComboBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.vereinTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.vereinLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.vornameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.vornameTextBox = new System.Windows.Forms.TextBox();
            this.GeburtstagDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SchiessabendPicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.schiessbuchDataGridView = new System.Windows.Forms.DataGridView();
            this.colDisziplin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zielscheibeLabel = new System.Windows.Forms.Label();
            this.zielscheibeTextBox = new System.Windows.Forms.TextBox();
            this.trefferDataGridView = new System.Windows.Forms.DataGridView();
            this.schritt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schussnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xinmm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yinmm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xrahmeninmm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yrahmeninmm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schuetze = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disziplin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zielscheibe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchrittText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.schuetzenTableAdapter = new schiessbuch.siusclubDataSetTableAdapters.schuetzenTableAdapter();
            this.tableAdapterManager = new schiessbuch.siusclubDataSetTableAdapters.TableAdapterManager();
            this.schiessbuchTableAdapter = new schiessbuch.siusclubDataSetTableAdapters.schiessbuchTableAdapter();
            this.schuetzenlisteTableAdapter = new schiessbuch.siusclubDataSetTableAdapters.schuetzenlisteTableAdapter();
            this.trefferTableAdapter = new schiessbuch.siusclubDataSetTableAdapters.trefferTableAdapter();
            this.vereineTableAdapter = new schiessbuch.siusclubDataSetTableAdapters.VereineTableAdapter();
            this.uebersichtgemeindemeisterschaftTableAdapter = new schiessbuch.gemeindemeisterschaftTableAdapters.uebersichtgemeindemeisterschaftTableAdapter();
            this.vereinslisteTableAdapter = new schiessbuch.gemeindemeisterschaftTableAdapters.vereinslisteTableAdapter();
            this.datumlisteTableAdapter = new schiessbuch.gemeindemeisterschaftTableAdapters.datumlisteTableAdapter();
            this.vereinsheimSiusclubDataSet1 = new schiessbuch.VereinsheimSiusclubDataSet1();
            this.uebersichtgemeindemeisterschaftBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.uebersichtgemeindemeisterschaftTableAdapter1 = new schiessbuch.VereinsheimSiusclubDataSet1TableAdapters.uebersichtgemeindemeisterschaftTableAdapter();
            this.uebersichtgemeindemeisterschaftTableAdapter3 = new schiessbuch.VereinsheimSiusclubDataSet2TableAdapters.uebersichtgemeindemeisterschaftTableAdapter();
            vereinLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schuetzenListeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siusclubDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siusclubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schuetzenListeBindingSourceA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schiessbuchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schuetzenBindingSource)).BeginInit();
            this.SchiessbuchContexMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schuetzenlisteschiessbuchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trefferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schiessbuchtrefferBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uebersichtgemeindemeisterschaftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gemeindemeisterschaftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gemeindemeisterschaft)).BeginInit();
            this.tabGemeindemeisterschaft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datumlisteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vereinslisteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gmmDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uebersichtgemeindemeisterschaftBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vereinsheimSiusclubDataSet2)).BeginInit();
            this.tabEinzelscheibe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEinzelScheibe)).BeginInit();
            this.tabStandUebersicht.SuspendLayout();
            this.UebersichtTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stand1SplitContainer)).BeginInit();
            this.Stand1SplitContainer.Panel1.SuspendLayout();
            this.Stand1SplitContainer.Panel2.SuspendLayout();
            this.Stand1SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stand1Zielscheibe)).BeginInit();
            this.Stand1SchussPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stand2SplitContainer)).BeginInit();
            this.Stand2SplitContainer.Panel1.SuspendLayout();
            this.Stand2SplitContainer.Panel2.SuspendLayout();
            this.Stand2SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stand2Zielscheibe)).BeginInit();
            this.Stand2SchussPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stand3SplitContainer)).BeginInit();
            this.Stand3SplitContainer.Panel1.SuspendLayout();
            this.Stand3SplitContainer.Panel2.SuspendLayout();
            this.Stand3SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stand3Zielscheibe)).BeginInit();
            this.Stand3SchussPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stand6SplitContainer)).BeginInit();
            this.Stand6SplitContainer.Panel1.SuspendLayout();
            this.Stand6SplitContainer.Panel2.SuspendLayout();
            this.Stand6SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stand6Zielscheibe)).BeginInit();
            this.Stand6SchussPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stand5SplitContainer)).BeginInit();
            this.Stand5SplitContainer.Panel1.SuspendLayout();
            this.Stand5SplitContainer.Panel2.SuspendLayout();
            this.Stand5SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stand5Zielscheibe)).BeginInit();
            this.Stand5SchussPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stand4SplitContainer)).BeginInit();
            this.Stand4SplitContainer.Panel1.SuspendLayout();
            this.Stand4SplitContainer.Panel2.SuspendLayout();
            this.Stand4SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stand4Zielscheibe)).BeginInit();
            this.Stand4SchussPanel.SuspendLayout();
            this.wanderpokal.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JahrespokalErwachseneDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JahrespokalJugendDGV)).BeginInit();
            this.KoenigTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerKoenig1)).BeginInit();
            this.splitContainerKoenig1.Panel1.SuspendLayout();
            this.splitContainerKoenig1.Panel2.SuspendLayout();
            this.splitContainerKoenig1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerKoenig2)).BeginInit();
            this.splitContainerKoenig2.Panel1.SuspendLayout();
            this.splitContainerKoenig2.Panel2.SuspendLayout();
            this.splitContainerKoenig2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KoenigSKGridView)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KoenigDKGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerKoenig3)).BeginInit();
            this.splitContainerKoenig3.Panel1.SuspendLayout();
            this.splitContainerKoenig3.Panel2.SuspendLayout();
            this.splitContainerKoenig3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KoenigAuflageGridView)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KoenigJUGGridView)).BeginInit();
            this.TagesAuswertung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Schiessabend)).BeginInit();
            this.AuswertungTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SchiessbuchTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vereineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siusclubDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schiessbuchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trefferDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vereinsheimSiusclubDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uebersichtgemeindemeisterschaftBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // vereinLabel1
            // 
            vereinLabel1.AutoSize = true;
            vereinLabel1.Location = new System.Drawing.Point(332, 174);
            vereinLabel1.Name = "vereinLabel1";
            vereinLabel1.Size = new System.Drawing.Size(39, 13);
            vereinLabel1.TabIndex = 27;
            vereinLabel1.Text = "verein:";
            // 
            // schuetzenListeBindingSource
            // 
            this.schuetzenListeBindingSource.DataMember = "schuetzenliste";
            this.schuetzenListeBindingSource.DataSource = this.siusclubDataSetBindingSource;
            this.schuetzenListeBindingSource.Sort = "Name ASC, Vorname ASC";
            // 
            // siusclubDataSetBindingSource
            // 
            this.siusclubDataSetBindingSource.DataSource = this.siusclubDataSet;
            this.siusclubDataSetBindingSource.Position = 0;
            // 
            // siusclubDataSet
            // 
            this.siusclubDataSet.DataSetName = "siusclubDataSet";
            this.siusclubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schiessbuchBindingSource
            // 
            this.schiessbuchBindingSource.DataMember = "schuetzen_schiessbuch";
            this.schiessbuchBindingSource.DataSource = this.schuetzenBindingSource;
            // 
            // schuetzenBindingSource
            // 
            this.schuetzenBindingSource.DataMember = "schuetzen";
            this.schuetzenBindingSource.DataSource = this.siusclubDataSet;
            // 
            // SchiessbuchContexMenu
            // 
            this.SchiessbuchContexMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveEntry,
            this.disziplinkorrigierenToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteEntry,
            this.eintratgültigSetzenToolStripMenuItem,
            this.toolStripSeparator3,
            this.auswertenEntry});
            this.SchiessbuchContexMenu.Name = "contextMenuStrip1";
            this.SchiessbuchContexMenu.Size = new System.Drawing.Size(196, 126);
            // 
            // moveEntry
            // 
            this.moveEntry.Name = "moveEntry";
            this.moveEntry.Size = new System.Drawing.Size(195, 22);
            this.moveEntry.Text = "Eintrag &verschieben ...";
            this.moveEntry.Click += new System.EventHandler(this.moveEntry_Click);
            // 
            // disziplinkorrigierenToolStripMenuItem
            // 
            this.disziplinkorrigierenToolStripMenuItem.Name = "disziplinkorrigierenToolStripMenuItem";
            this.disziplinkorrigierenToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.disziplinkorrigierenToolStripMenuItem.Text = "Disziplin &korrigieren ...";
            this.disziplinkorrigierenToolStripMenuItem.Click += new System.EventHandler(this.disziplinkorrigierenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // deleteEntry
            // 
            this.deleteEntry.Name = "deleteEntry";
            this.deleteEntry.Size = new System.Drawing.Size(195, 22);
            this.deleteEntry.Text = "Eintrag &ungültig setzen";
            this.deleteEntry.Click += new System.EventHandler(this.deleteEntry_Click);
            // 
            // eintratgültigSetzenToolStripMenuItem
            // 
            this.eintratgültigSetzenToolStripMenuItem.Name = "eintratgültigSetzenToolStripMenuItem";
            this.eintratgültigSetzenToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.eintratgültigSetzenToolStripMenuItem.Text = "Eintrag &gültig setzen";
            this.eintratgültigSetzenToolStripMenuItem.Click += new System.EventHandler(this.eintratgültigSetzenToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(192, 6);
            // 
            // auswertenEntry
            // 
            this.auswertenEntry.Name = "auswertenEntry";
            this.auswertenEntry.Size = new System.Drawing.Size(195, 22);
            this.auswertenEntry.Text = "&Auswertung";
            this.auswertenEntry.Click += new System.EventHandler(this.auswertenEntry_Click);
            // 
            // schuetzenlisteschiessbuchBindingSource
            // 
            this.schuetzenlisteschiessbuchBindingSource.DataMember = "schuetzenliste_schiessbuch";
            this.schuetzenlisteschiessbuchBindingSource.DataSource = this.schuetzenListeBindingSource;
            // 
            // trefferBindingSource
            // 
            this.trefferBindingSource.DataMember = "schiessbuch_treffer";
            this.trefferBindingSource.DataSource = this.schiessbuchBindingSource;
            // 
            // schiessbuchtrefferBindingSource
            // 
            this.schiessbuchtrefferBindingSource.DataMember = "schiessbuch_treffer";
            this.schiessbuchtrefferBindingSource.DataSource = this.schuetzenlisteschiessbuchBindingSource;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schießjahrToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.toolStripMenuItem1,
            this.backupToolStripMenuItem,
            this.vereinsmeisterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // schießjahrToolStripMenuItem
            // 
            this.schießjahrToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesSchießjahrBeginnenToolStripMenuItem,
            this.schießjahrAuswählenToolStripMenuItem});
            this.schießjahrToolStripMenuItem.Name = "schießjahrToolStripMenuItem";
            this.schießjahrToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.schießjahrToolStripMenuItem.Text = "&Schießjahr";
            // 
            // neuesSchießjahrBeginnenToolStripMenuItem
            // 
            this.neuesSchießjahrBeginnenToolStripMenuItem.Name = "neuesSchießjahrBeginnenToolStripMenuItem";
            this.neuesSchießjahrBeginnenToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.neuesSchießjahrBeginnenToolStripMenuItem.Text = "&Neues Schießjahr beginnen";
            this.neuesSchießjahrBeginnenToolStripMenuItem.Click += new System.EventHandler(this.neuesSchießjahrBeginnenToolStripMenuItem_Click);
            // 
            // schießjahrAuswählenToolStripMenuItem
            // 
            this.schießjahrAuswählenToolStripMenuItem.Name = "schießjahrAuswählenToolStripMenuItem";
            this.schießjahrAuswählenToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.schießjahrAuswählenToolStripMenuItem.Text = "&Schießjahr auswählen";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bearbeitungsmodusToolStripMenuItem,
            this.toolStripSeparator2,
            this.einstellungenToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "&Bearbeiten";
            // 
            // bearbeitungsmodusToolStripMenuItem
            // 
            this.bearbeitungsmodusToolStripMenuItem.CheckOnClick = true;
            this.bearbeitungsmodusToolStripMenuItem.Name = "bearbeitungsmodusToolStripMenuItem";
            this.bearbeitungsmodusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bearbeitungsmodusToolStripMenuItem.Text = "&Bearbeitungsmodus";
            this.bearbeitungsmodusToolStripMenuItem.Click += new System.EventHandler(this.bearbeitungsmodusToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.einstellungenToolStripMenuItem.Text = "&Einstellungen ...";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem1.Text = "&Gauliga";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(183, 22);
            this.toolStripMenuItem2.Text = "Ergebnisliste &Gauliga";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordnerFürSicherungenFestlegenToolStripMenuItem,
            this.pfadZuMysqldumpFestlegenToolStripMenuItem});
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.backupToolStripMenuItem.Text = "S&icherungen";
            // 
            // ordnerFürSicherungenFestlegenToolStripMenuItem
            // 
            this.ordnerFürSicherungenFestlegenToolStripMenuItem.Name = "ordnerFürSicherungenFestlegenToolStripMenuItem";
            this.ordnerFürSicherungenFestlegenToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.ordnerFürSicherungenFestlegenToolStripMenuItem.Text = "&Ordner für Sicherungen festlegen";
            this.ordnerFürSicherungenFestlegenToolStripMenuItem.Click += new System.EventHandler(this.ordnerFürSicherungenFestlegenToolStripMenuItem_Click);
            // 
            // pfadZuMysqldumpFestlegenToolStripMenuItem
            // 
            this.pfadZuMysqldumpFestlegenToolStripMenuItem.Name = "pfadZuMysqldumpFestlegenToolStripMenuItem";
            this.pfadZuMysqldumpFestlegenToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.pfadZuMysqldumpFestlegenToolStripMenuItem.Text = "&Pfad zu mysqldump festlegen";
            this.pfadZuMysqldumpFestlegenToolStripMenuItem.Click += new System.EventHandler(this.pfadZuMysqldumpFestlegenToolStripMenuItem_Click);
            // 
            // vereinsmeisterToolStripMenuItem
            // 
            this.vereinsmeisterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jahresübersichtToolStripMenuItem});
            this.vereinsmeisterToolStripMenuItem.Name = "vereinsmeisterToolStripMenuItem";
            this.vereinsmeisterToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.vereinsmeisterToolStripMenuItem.Text = "Vereinsmeister";
            this.vereinsmeisterToolStripMenuItem.Click += new System.EventHandler(this.vereinsmeisterToolStripMenuItem_Click);
            // 
            // jahresübersichtToolStripMenuItem
            // 
            this.jahresübersichtToolStripMenuItem.Name = "jahresübersichtToolStripMenuItem";
            this.jahresübersichtToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.jahresübersichtToolStripMenuItem.Text = "&Jahresübersicht";
            this.jahresübersichtToolStripMenuItem.Click += new System.EventHandler(this.jahresübersichtToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(747, 494);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Kassenbericht drucken...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(893, 494);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 23);
            this.button7.TabIndex = 12;
            this.button7.Text = "&Liste drucken...";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.schuetzenListeBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.saveToolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(984, 25);
            this.bindingNavigator1.TabIndex = 31;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem1_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // saveToolStripButton1
            // 
            this.saveToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton1.Enabled = false;
            this.saveToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton1.Image")));
            this.saveToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton1.Name = "saveToolStripButton1";
            this.saveToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton1.Text = "&Save";
            this.saveToolStripButton1.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // uebersichtgemeindemeisterschaftBindingSource
            // 
            this.uebersichtgemeindemeisterschaftBindingSource.DataMember = "uebersichtgemeindemeisterschaft";
            this.uebersichtgemeindemeisterschaftBindingSource.DataSource = this.gemeindemeisterschaftBindingSource;
            // 
            // gemeindemeisterschaftBindingSource
            // 
            this.gemeindemeisterschaftBindingSource.DataSource = this.gemeindemeisterschaft;
            this.gemeindemeisterschaftBindingSource.Position = 0;
            // 
            // gemeindemeisterschaft
            // 
            this.gemeindemeisterschaft.DataSetName = "gemeindemeisterschaft";
            this.gemeindemeisterschaft.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabGemeindemeisterschaft
            // 
            this.tabGemeindemeisterschaft.Controls.Add(this.label13);
            this.tabGemeindemeisterschaft.Controls.Add(this.cbDatumFiltern);
            this.tabGemeindemeisterschaft.Controls.Add(this.btnRefresh);
            this.tabGemeindemeisterschaft.Controls.Add(this.cbVereineFiltern);
            this.tabGemeindemeisterschaft.Controls.Add(this.comboDatumFiltern);
            this.tabGemeindemeisterschaft.Controls.Add(this.comboVereineFiltern);
            this.tabGemeindemeisterschaft.Controls.Add(this.btnGmmDruck);
            this.tabGemeindemeisterschaft.Controls.Add(this.gmmDGV);
            this.tabGemeindemeisterschaft.Location = new System.Drawing.Point(4, 22);
            this.tabGemeindemeisterschaft.Name = "tabGemeindemeisterschaft";
            this.tabGemeindemeisterschaft.Size = new System.Drawing.Size(952, 419);
            this.tabGemeindemeisterschaft.TabIndex = 8;
            this.tabGemeindemeisterschaft.Text = "Gemeindemeisterschaft";
            this.tabGemeindemeisterschaft.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(283, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "<--- Filter --->";
            // 
            // cbDatumFiltern
            // 
            this.cbDatumFiltern.AutoSize = true;
            this.cbDatumFiltern.Location = new System.Drawing.Point(426, 9);
            this.cbDatumFiltern.Name = "cbDatumFiltern";
            this.cbDatumFiltern.Size = new System.Drawing.Size(15, 14);
            this.cbDatumFiltern.TabIndex = 18;
            this.cbDatumFiltern.UseVisualStyleBackColor = true;
            this.cbDatumFiltern.CheckedChanged += new System.EventHandler(this.cbDatumFiltern_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(574, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 20);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Aktualisieren";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbVereineFiltern
            // 
            this.cbVereineFiltern.AutoSize = true;
            this.cbVereineFiltern.Location = new System.Drawing.Point(29, 9);
            this.cbVereineFiltern.Name = "cbVereineFiltern";
            this.cbVereineFiltern.Size = new System.Drawing.Size(15, 14);
            this.cbVereineFiltern.TabIndex = 17;
            this.cbVereineFiltern.UseVisualStyleBackColor = true;
            this.cbVereineFiltern.CheckedChanged += new System.EventHandler(this.cbVereineFiltern_CheckedChanged);
            // 
            // comboDatumFiltern
            // 
            this.comboDatumFiltern.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.datumlisteBindingSource, "Datum", true));
            this.comboDatumFiltern.DataSource = this.datumlisteBindingSource;
            this.comboDatumFiltern.DisplayMember = "Datum";
            this.comboDatumFiltern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDatumFiltern.Enabled = false;
            this.comboDatumFiltern.FormattingEnabled = true;
            this.comboDatumFiltern.Location = new System.Drawing.Point(447, 5);
            this.comboDatumFiltern.Name = "comboDatumFiltern";
            this.comboDatumFiltern.Size = new System.Drawing.Size(121, 21);
            this.comboDatumFiltern.TabIndex = 16;
            this.comboDatumFiltern.ValueMember = "Datum";
            this.comboDatumFiltern.Visible = false;
            this.comboDatumFiltern.DropDown += new System.EventHandler(this.comboDatumFiltern_DropDown);
            this.comboDatumFiltern.SelectedValueChanged += new System.EventHandler(this.comboDatumFiltern_SelectedValueChanged);
            this.comboDatumFiltern.TextChanged += new System.EventHandler(this.comboDatumFiltern_TextChanged);
            // 
            // datumlisteBindingSource
            // 
            this.datumlisteBindingSource.DataMember = "datumliste";
            this.datumlisteBindingSource.DataSource = this.gemeindemeisterschaft;
            // 
            // comboVereineFiltern
            // 
            this.comboVereineFiltern.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vereinslisteBindingSource, "Verein", true));
            this.comboVereineFiltern.DataSource = this.vereinslisteBindingSource;
            this.comboVereineFiltern.DisplayMember = "Verein";
            this.comboVereineFiltern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVereineFiltern.Enabled = false;
            this.comboVereineFiltern.FormattingEnabled = true;
            this.comboVereineFiltern.Location = new System.Drawing.Point(50, 4);
            this.comboVereineFiltern.Name = "comboVereineFiltern";
            this.comboVereineFiltern.Size = new System.Drawing.Size(136, 21);
            this.comboVereineFiltern.TabIndex = 15;
            this.comboVereineFiltern.ValueMember = "Verein";
            this.comboVereineFiltern.Visible = false;
            this.comboVereineFiltern.DropDown += new System.EventHandler(this.comboVereineFiltern_DropDown);
            this.comboVereineFiltern.SelectedValueChanged += new System.EventHandler(this.comboVereineFiltern_SelectedValueChanged);
            this.comboVereineFiltern.TextChanged += new System.EventHandler(this.comboVereineFiltern_TextChanged);
            // 
            // vereinslisteBindingSource
            // 
            this.vereinslisteBindingSource.DataMember = "vereinsliste";
            this.vereinslisteBindingSource.DataSource = this.gemeindemeisterschaft;
            // 
            // btnGmmDruck
            // 
            this.btnGmmDruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGmmDruck.Location = new System.Drawing.Point(871, 4);
            this.btnGmmDruck.Name = "btnGmmDruck";
            this.btnGmmDruck.Size = new System.Drawing.Size(75, 23);
            this.btnGmmDruck.TabIndex = 11;
            this.btnGmmDruck.Text = "&Drucken...";
            this.btnGmmDruck.UseVisualStyleBackColor = true;
            this.btnGmmDruck.Click += new System.EventHandler(this.btnGmmDruck_Click);
            // 
            // gmmDGV
            // 
            this.gmmDGV.AllowUserToAddRows = false;
            this.gmmDGV.AllowUserToDeleteRows = false;
            this.gmmDGV.AllowUserToResizeColumns = false;
            this.gmmDGV.AllowUserToResizeRows = false;
            this.gmmDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmmDGV.AutoGenerateColumns = false;
            this.gmmDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gmmDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vereinDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn,
            this.klasseDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.gemeindemeisterLuftgewehrDataGridViewTextBoxColumn,
            this.gemeindemeisterLuftpistoleDataGridViewTextBoxColumn,
            this.gemeindemeisterLuftgewehrAuflageDataGridViewTextBoxColumn,
            this.gemeindemeisterLuftpistoleAuflageDataGridViewTextBoxColumn,
            this.preisLuftgewehrDataGridViewTextBoxColumn,
            this.preisLuftpistoleDataGridViewTextBoxColumn,
            this.preisLuftgewehrAuflageDataGridViewTextBoxColumn,
            this.preisLuftpistoleAuflageDataGridViewTextBoxColumn,
            this.bürgermeisterpokalLuftgewehrDataGridViewTextBoxColumn,
            this.bürgermeisterpokalLuftpistoleDataGridViewTextBoxColumn,
            this.bürgermeisterpokalLuftgewehrAuflageDataGridViewTextBoxColumn,
            this.bürgermeisterpokalLuftpistoleAuflageDataGridViewTextBoxColumn,
            this.gedächtnispokalLuftgewehrDataGridViewTextBoxColumn,
            this.gedächtnispokalLuftpistoleDataGridViewTextBoxColumn,
            this.gedächtnispokalLuftgewehrAuflageDataGridViewTextBoxColumn,
            this.gedächtnispokalLuftpistoleAuflageDataGridViewTextBoxColumn,
            this.schiessjahrIdDataGridViewTextBoxColumn,
            this.schuetzeIDDataGridViewTextBoxColumn});
            this.gmmDGV.DataSource = this.uebersichtgemeindemeisterschaftBindingSource4;
            this.gmmDGV.Location = new System.Drawing.Point(6, 38);
            this.gmmDGV.Name = "gmmDGV";
            this.gmmDGV.Size = new System.Drawing.Size(940, 381);
            this.gmmDGV.TabIndex = 9;
            // 
            // vereinDataGridViewTextBoxColumn
            // 
            this.vereinDataGridViewTextBoxColumn.DataPropertyName = "Verein";
            this.vereinDataGridViewTextBoxColumn.Frozen = true;
            this.vereinDataGridViewTextBoxColumn.HeaderText = "Verein";
            this.vereinDataGridViewTextBoxColumn.Name = "vereinDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.Frozen = true;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            this.vornameDataGridViewTextBoxColumn.Frozen = true;
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            // 
            // klasseDataGridViewTextBoxColumn
            // 
            this.klasseDataGridViewTextBoxColumn.DataPropertyName = "Klasse";
            this.klasseDataGridViewTextBoxColumn.Frozen = true;
            this.klasseDataGridViewTextBoxColumn.HeaderText = "Klasse";
            this.klasseDataGridViewTextBoxColumn.Name = "klasseDataGridViewTextBoxColumn";
            this.klasseDataGridViewTextBoxColumn.Width = 50;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.Frozen = true;
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.Width = 70;
            // 
            // gemeindemeisterLuftgewehrDataGridViewTextBoxColumn
            // 
            this.gemeindemeisterLuftgewehrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gemeindemeisterLuftgewehrDataGridViewTextBoxColumn.DataPropertyName = "Gemeindemeister Luftgewehr";
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gemeindemeisterLuftgewehrDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle45;
            this.gemeindemeisterLuftgewehrDataGridViewTextBoxColumn.HeaderText = "Gemeindemeister Luftgewehr";
            this.gemeindemeisterLuftgewehrDataGridViewTextBoxColumn.Name = "gemeindemeisterLuftgewehrDataGridViewTextBoxColumn";
            this.gemeindemeisterLuftgewehrDataGridViewTextBoxColumn.ToolTipText = "Gemeindemeister Luftgewehr";
            this.gemeindemeisterLuftgewehrDataGridViewTextBoxColumn.Width = 60;
            // 
            // gemeindemeisterLuftpistoleDataGridViewTextBoxColumn
            // 
            this.gemeindemeisterLuftpistoleDataGridViewTextBoxColumn.DataPropertyName = "Gemeindemeister Luftpistole";
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gemeindemeisterLuftpistoleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle46;
            this.gemeindemeisterLuftpistoleDataGridViewTextBoxColumn.HeaderText = "Gemeindemeister Luftpistole";
            this.gemeindemeisterLuftpistoleDataGridViewTextBoxColumn.Name = "gemeindemeisterLuftpistoleDataGridViewTextBoxColumn";
            this.gemeindemeisterLuftpistoleDataGridViewTextBoxColumn.ToolTipText = "Gemeindemeister Luftpistole";
            this.gemeindemeisterLuftpistoleDataGridViewTextBoxColumn.Width = 60;
            // 
            // gemeindemeisterLuftgewehrAuflageDataGridViewTextBoxColumn
            // 
            this.gemeindemeisterLuftgewehrAuflageDataGridViewTextBoxColumn.DataPropertyName = "Gemeindemeister Luftgewehr Auflage";
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gemeindemeisterLuftgewehrAuflageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle47;
            this.gemeindemeisterLuftgewehrAuflageDataGridViewTextBoxColumn.HeaderText = "Gemeindemeister Luftgewehr Auflage";
            this.gemeindemeisterLuftgewehrAuflageDataGridViewTextBoxColumn.Name = "gemeindemeisterLuftgewehrAuflageDataGridViewTextBoxColumn";
            this.gemeindemeisterLuftgewehrAuflageDataGridViewTextBoxColumn.ToolTipText = "Gemeindemeister Luftgewehr Auflage";
            this.gemeindemeisterLuftgewehrAuflageDataGridViewTextBoxColumn.Width = 60;
            // 
            // gemeindemeisterLuftpistoleAuflageDataGridViewTextBoxColumn
            // 
            this.gemeindemeisterLuftpistoleAuflageDataGridViewTextBoxColumn.DataPropertyName = "Gemeindemeister Luftpistole Auflage";
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gemeindemeisterLuftpistoleAuflageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle48;
            this.gemeindemeisterLuftpistoleAuflageDataGridViewTextBoxColumn.HeaderText = "Gemeindemeister Luftpistole Auflage";
            this.gemeindemeisterLuftpistoleAuflageDataGridViewTextBoxColumn.Name = "gemeindemeisterLuftpistoleAuflageDataGridViewTextBoxColumn";
            this.gemeindemeisterLuftpistoleAuflageDataGridViewTextBoxColumn.ToolTipText = "Gemeindemeister Luftpistole Auflage";
            this.gemeindemeisterLuftpistoleAuflageDataGridViewTextBoxColumn.Width = 60;
            // 
            // preisLuftgewehrDataGridViewTextBoxColumn
            // 
            this.preisLuftgewehrDataGridViewTextBoxColumn.DataPropertyName = "Preis Luftgewehr";
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.preisLuftgewehrDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle49;
            this.preisLuftgewehrDataGridViewTextBoxColumn.HeaderText = "Preis Luftgewehr";
            this.preisLuftgewehrDataGridViewTextBoxColumn.Name = "preisLuftgewehrDataGridViewTextBoxColumn";
            this.preisLuftgewehrDataGridViewTextBoxColumn.ToolTipText = "Preis Luftgewehr";
            this.preisLuftgewehrDataGridViewTextBoxColumn.Width = 60;
            // 
            // preisLuftpistoleDataGridViewTextBoxColumn
            // 
            this.preisLuftpistoleDataGridViewTextBoxColumn.DataPropertyName = "Preis Luftpistole";
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.preisLuftpistoleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle50;
            this.preisLuftpistoleDataGridViewTextBoxColumn.HeaderText = "Preis Luftpistole";
            this.preisLuftpistoleDataGridViewTextBoxColumn.Name = "preisLuftpistoleDataGridViewTextBoxColumn";
            this.preisLuftpistoleDataGridViewTextBoxColumn.ToolTipText = "Preis Luftpistole";
            this.preisLuftpistoleDataGridViewTextBoxColumn.Width = 60;
            // 
            // preisLuftgewehrAuflageDataGridViewTextBoxColumn
            // 
            this.preisLuftgewehrAuflageDataGridViewTextBoxColumn.DataPropertyName = "Preis Luftgewehr Auflage";
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.preisLuftgewehrAuflageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle51;
            this.preisLuftgewehrAuflageDataGridViewTextBoxColumn.HeaderText = "Preis Luftgewehr Auflage";
            this.preisLuftgewehrAuflageDataGridViewTextBoxColumn.Name = "preisLuftgewehrAuflageDataGridViewTextBoxColumn";
            this.preisLuftgewehrAuflageDataGridViewTextBoxColumn.ToolTipText = "Preis Luftgewehr Auflage";
            this.preisLuftgewehrAuflageDataGridViewTextBoxColumn.Width = 60;
            // 
            // preisLuftpistoleAuflageDataGridViewTextBoxColumn
            // 
            this.preisLuftpistoleAuflageDataGridViewTextBoxColumn.DataPropertyName = "Preis Luftpistole Auflage";
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.preisLuftpistoleAuflageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle52;
            this.preisLuftpistoleAuflageDataGridViewTextBoxColumn.HeaderText = "Preis Luftpistole Auflage";
            this.preisLuftpistoleAuflageDataGridViewTextBoxColumn.Name = "preisLuftpistoleAuflageDataGridViewTextBoxColumn";
            this.preisLuftpistoleAuflageDataGridViewTextBoxColumn.ToolTipText = "Preis Luftpistole Auflage";
            this.preisLuftpistoleAuflageDataGridViewTextBoxColumn.Width = 60;
            // 
            // bürgermeisterpokalLuftgewehrDataGridViewTextBoxColumn
            // 
            this.bürgermeisterpokalLuftgewehrDataGridViewTextBoxColumn.DataPropertyName = "Buergermeisterpokal Luftgewehr";
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.bürgermeisterpokalLuftgewehrDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle53;
            this.bürgermeisterpokalLuftgewehrDataGridViewTextBoxColumn.HeaderText = "Bürgermeisterpokal Luftgewehr";
            this.bürgermeisterpokalLuftgewehrDataGridViewTextBoxColumn.Name = "bürgermeisterpokalLuftgewehrDataGridViewTextBoxColumn";
            this.bürgermeisterpokalLuftgewehrDataGridViewTextBoxColumn.ToolTipText = "Bürgermeisterpokal Luftgewehr";
            this.bürgermeisterpokalLuftgewehrDataGridViewTextBoxColumn.Width = 60;
            // 
            // bürgermeisterpokalLuftpistoleDataGridViewTextBoxColumn
            // 
            this.bürgermeisterpokalLuftpistoleDataGridViewTextBoxColumn.DataPropertyName = "Buergermeisterpokal Luftpistole";
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.bürgermeisterpokalLuftpistoleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle54;
            this.bürgermeisterpokalLuftpistoleDataGridViewTextBoxColumn.HeaderText = "Bürgermeisterpokal Luftpistole";
            this.bürgermeisterpokalLuftpistoleDataGridViewTextBoxColumn.Name = "bürgermeisterpokalLuftpistoleDataGridViewTextBoxColumn";
            this.bürgermeisterpokalLuftpistoleDataGridViewTextBoxColumn.ToolTipText = "Bürgermeisterpokal Luftpistole";
            this.bürgermeisterpokalLuftpistoleDataGridViewTextBoxColumn.Width = 60;
            // 
            // bürgermeisterpokalLuftgewehrAuflageDataGridViewTextBoxColumn
            // 
            this.bürgermeisterpokalLuftgewehrAuflageDataGridViewTextBoxColumn.DataPropertyName = "Buergermeisterpokal Luftgewehr Auflage";
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.bürgermeisterpokalLuftgewehrAuflageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle55;
            this.bürgermeisterpokalLuftgewehrAuflageDataGridViewTextBoxColumn.HeaderText = "Bürgermeisterpokal Luftgewehr Auflage";
            this.bürgermeisterpokalLuftgewehrAuflageDataGridViewTextBoxColumn.Name = "bürgermeisterpokalLuftgewehrAuflageDataGridViewTextBoxColumn";
            this.bürgermeisterpokalLuftgewehrAuflageDataGridViewTextBoxColumn.ToolTipText = "Bürgermeisterpokal Luftgewehr Auflage";
            this.bürgermeisterpokalLuftgewehrAuflageDataGridViewTextBoxColumn.Width = 60;
            // 
            // bürgermeisterpokalLuftpistoleAuflageDataGridViewTextBoxColumn
            // 
            this.bürgermeisterpokalLuftpistoleAuflageDataGridViewTextBoxColumn.DataPropertyName = "Buergermeisterpokal Luftpistole Auflage";
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.bürgermeisterpokalLuftpistoleAuflageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle56;
            this.bürgermeisterpokalLuftpistoleAuflageDataGridViewTextBoxColumn.HeaderText = "Bürgermeisterpokal Luftpistole Auflage";
            this.bürgermeisterpokalLuftpistoleAuflageDataGridViewTextBoxColumn.Name = "bürgermeisterpokalLuftpistoleAuflageDataGridViewTextBoxColumn";
            this.bürgermeisterpokalLuftpistoleAuflageDataGridViewTextBoxColumn.ToolTipText = "Bürgermeisterpokal Luftpistole Auflage";
            this.bürgermeisterpokalLuftpistoleAuflageDataGridViewTextBoxColumn.Width = 60;
            // 
            // gedächtnispokalLuftgewehrDataGridViewTextBoxColumn
            // 
            this.gedächtnispokalLuftgewehrDataGridViewTextBoxColumn.DataPropertyName = "Gedaechtnispokal Luftgewehr";
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gedächtnispokalLuftgewehrDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle57;
            this.gedächtnispokalLuftgewehrDataGridViewTextBoxColumn.HeaderText = "Gedächtnispokal Luftgewehr";
            this.gedächtnispokalLuftgewehrDataGridViewTextBoxColumn.Name = "gedächtnispokalLuftgewehrDataGridViewTextBoxColumn";
            this.gedächtnispokalLuftgewehrDataGridViewTextBoxColumn.ToolTipText = "Gedächtnispokal Luftgewehr";
            this.gedächtnispokalLuftgewehrDataGridViewTextBoxColumn.Width = 60;
            // 
            // gedächtnispokalLuftpistoleDataGridViewTextBoxColumn
            // 
            this.gedächtnispokalLuftpistoleDataGridViewTextBoxColumn.DataPropertyName = "Gedaechtnispokal Luftpistole";
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gedächtnispokalLuftpistoleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle58;
            this.gedächtnispokalLuftpistoleDataGridViewTextBoxColumn.HeaderText = "Gedächtnispokal Luftpistole";
            this.gedächtnispokalLuftpistoleDataGridViewTextBoxColumn.Name = "gedächtnispokalLuftpistoleDataGridViewTextBoxColumn";
            this.gedächtnispokalLuftpistoleDataGridViewTextBoxColumn.ToolTipText = "Gedächtnispokal Luftpistole";
            this.gedächtnispokalLuftpistoleDataGridViewTextBoxColumn.Width = 60;
            // 
            // gedächtnispokalLuftgewehrAuflageDataGridViewTextBoxColumn
            // 
            this.gedächtnispokalLuftgewehrAuflageDataGridViewTextBoxColumn.DataPropertyName = "Gedaechtnispokal Luftgewehr Auflage";
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gedächtnispokalLuftgewehrAuflageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle59;
            this.gedächtnispokalLuftgewehrAuflageDataGridViewTextBoxColumn.HeaderText = "Gedächtnispokal Luftgewehr Auflage";
            this.gedächtnispokalLuftgewehrAuflageDataGridViewTextBoxColumn.Name = "gedächtnispokalLuftgewehrAuflageDataGridViewTextBoxColumn";
            this.gedächtnispokalLuftgewehrAuflageDataGridViewTextBoxColumn.ToolTipText = "Gedächtnispokal Luftgewehr Auflage";
            this.gedächtnispokalLuftgewehrAuflageDataGridViewTextBoxColumn.Width = 60;
            // 
            // gedächtnispokalLuftpistoleAuflageDataGridViewTextBoxColumn
            // 
            this.gedächtnispokalLuftpistoleAuflageDataGridViewTextBoxColumn.DataPropertyName = "Gedaechtnispokal Luftpistole Auflage";
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gedächtnispokalLuftpistoleAuflageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle60;
            this.gedächtnispokalLuftpistoleAuflageDataGridViewTextBoxColumn.HeaderText = "Gedächtnispokal Luftpistole Auflage";
            this.gedächtnispokalLuftpistoleAuflageDataGridViewTextBoxColumn.Name = "gedächtnispokalLuftpistoleAuflageDataGridViewTextBoxColumn";
            this.gedächtnispokalLuftpistoleAuflageDataGridViewTextBoxColumn.ToolTipText = "Gedächtnispokal Luftpistole Auflage";
            this.gedächtnispokalLuftpistoleAuflageDataGridViewTextBoxColumn.Width = 60;
            // 
            // schiessjahrIdDataGridViewTextBoxColumn
            // 
            this.schiessjahrIdDataGridViewTextBoxColumn.DataPropertyName = "schiessjahrId";
            this.schiessjahrIdDataGridViewTextBoxColumn.HeaderText = "schiessjahrId";
            this.schiessjahrIdDataGridViewTextBoxColumn.Name = "schiessjahrIdDataGridViewTextBoxColumn";
            this.schiessjahrIdDataGridViewTextBoxColumn.Visible = false;
            this.schiessjahrIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // schuetzeIDDataGridViewTextBoxColumn
            // 
            this.schuetzeIDDataGridViewTextBoxColumn.DataPropertyName = "SchuetzeID";
            this.schuetzeIDDataGridViewTextBoxColumn.HeaderText = "SchuetzeID";
            this.schuetzeIDDataGridViewTextBoxColumn.Name = "schuetzeIDDataGridViewTextBoxColumn";
            this.schuetzeIDDataGridViewTextBoxColumn.Visible = false;
            this.schuetzeIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // uebersichtgemeindemeisterschaftBindingSource4
            // 
            this.uebersichtgemeindemeisterschaftBindingSource4.DataMember = "uebersichtgemeindemeisterschaft";
            this.uebersichtgemeindemeisterschaftBindingSource4.DataSource = this.vereinsheimSiusclubDataSet2;
            // 
            // vereinsheimSiusclubDataSet2
            // 
            this.vereinsheimSiusclubDataSet2.DataSetName = "VereinsheimSiusclubDataSet2";
            this.vereinsheimSiusclubDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabEinzelscheibe
            // 
            this.tabEinzelscheibe.Controls.Add(this.pictureBoxEinzelScheibe);
            this.tabEinzelscheibe.Location = new System.Drawing.Point(4, 22);
            this.tabEinzelscheibe.Name = "tabEinzelscheibe";
            this.tabEinzelscheibe.Size = new System.Drawing.Size(952, 419);
            this.tabEinzelscheibe.TabIndex = 7;
            this.tabEinzelscheibe.Text = "Einzelscheibe";
            this.tabEinzelscheibe.UseVisualStyleBackColor = true;
            // 
            // pictureBoxEinzelScheibe
            // 
            this.pictureBoxEinzelScheibe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxEinzelScheibe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEinzelScheibe.Image = global::schiessbuch.Properties.Resources.Luftgewehr;
            this.pictureBoxEinzelScheibe.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEinzelScheibe.Name = "pictureBoxEinzelScheibe";
            this.pictureBoxEinzelScheibe.Size = new System.Drawing.Size(372, 423);
            this.pictureBoxEinzelScheibe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEinzelScheibe.TabIndex = 0;
            this.pictureBoxEinzelScheibe.TabStop = false;
            this.pictureBoxEinzelScheibe.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxEinzelScheibe_Paint);
            this.pictureBoxEinzelScheibe.Resize += new System.EventHandler(this.pictureBox3_Resize);
            // 
            // tabStandUebersicht
            // 
            this.tabStandUebersicht.Controls.Add(this.UebersichtTableLayoutPanel);
            this.tabStandUebersicht.Location = new System.Drawing.Point(4, 22);
            this.tabStandUebersicht.Name = "tabStandUebersicht";
            this.tabStandUebersicht.Size = new System.Drawing.Size(952, 419);
            this.tabStandUebersicht.TabIndex = 6;
            this.tabStandUebersicht.Text = "Übersicht";
            this.tabStandUebersicht.UseVisualStyleBackColor = true;
            // 
            // UebersichtTableLayoutPanel
            // 
            this.UebersichtTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.UebersichtTableLayoutPanel.ColumnCount = 3;
            this.UebersichtTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.UebersichtTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.UebersichtTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.UebersichtTableLayoutPanel.Controls.Add(this.Stand1SplitContainer, 0, 0);
            this.UebersichtTableLayoutPanel.Controls.Add(this.Stand2SplitContainer, 1, 0);
            this.UebersichtTableLayoutPanel.Controls.Add(this.Stand3SplitContainer, 2, 0);
            this.UebersichtTableLayoutPanel.Controls.Add(this.Stand6SplitContainer, 2, 1);
            this.UebersichtTableLayoutPanel.Controls.Add(this.Stand5SplitContainer, 1, 1);
            this.UebersichtTableLayoutPanel.Controls.Add(this.Stand4SplitContainer, 0, 1);
            this.UebersichtTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UebersichtTableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.UebersichtTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.UebersichtTableLayoutPanel.Name = "UebersichtTableLayoutPanel";
            this.UebersichtTableLayoutPanel.RowCount = 2;
            this.UebersichtTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UebersichtTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UebersichtTableLayoutPanel.Size = new System.Drawing.Size(952, 419);
            this.UebersichtTableLayoutPanel.TabIndex = 0;
            this.UebersichtTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UebersichtTableLayoutPanel_Paint);
            this.UebersichtTableLayoutPanel.Resize += new System.EventHandler(this.tableLayoutPanel9_Resize);
            // 
            // Stand1SplitContainer
            // 
            this.Stand1SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stand1SplitContainer.Location = new System.Drawing.Point(6, 6);
            this.Stand1SplitContainer.Name = "Stand1SplitContainer";
            // 
            // Stand1SplitContainer.Panel1
            // 
            this.Stand1SplitContainer.Panel1.Controls.Add(this.stand1Zielscheibe);
            // 
            // Stand1SplitContainer.Panel2
            // 
            this.Stand1SplitContainer.Panel2.Controls.Add(this.lblProbe1);
            this.Stand1SplitContainer.Panel2.Controls.Add(this.txtSchussStand1);
            this.Stand1SplitContainer.Panel2.Controls.Add(this.lblSchussStand1);
            this.Stand1SplitContainer.Panel2.Controls.Add(this.txtDisziplinStand1);
            this.Stand1SplitContainer.Panel2.Controls.Add(this.lblDisziplinStand1);
            this.Stand1SplitContainer.Panel2.Controls.Add(this.txtSchuetzeStand1);
            this.Stand1SplitContainer.Panel2.Controls.Add(this.lblSchuetzeStand1);
            this.Stand1SplitContainer.Panel2.Controls.Add(this.Stand1SchussPanel);
            this.Stand1SplitContainer.Size = new System.Drawing.Size(307, 199);
            this.Stand1SplitContainer.SplitterDistance = 102;
            this.Stand1SplitContainer.TabIndex = 2;
            // 
            // stand1Zielscheibe
            // 
            this.stand1Zielscheibe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stand1Zielscheibe.Location = new System.Drawing.Point(0, 0);
            this.stand1Zielscheibe.Name = "stand1Zielscheibe";
            this.stand1Zielscheibe.Size = new System.Drawing.Size(102, 199);
            this.stand1Zielscheibe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stand1Zielscheibe.TabIndex = 0;
            this.stand1Zielscheibe.TabStop = false;
            this.stand1Zielscheibe.Paint += new System.Windows.Forms.PaintEventHandler(this.stand1Zielscheibe_Paint);
            this.stand1Zielscheibe.DoubleClick += new System.EventHandler(this.stand1Zielscheibe_DoubleClick);
            // 
            // lblProbe1
            // 
            this.lblProbe1.AutoSize = true;
            this.lblProbe1.Location = new System.Drawing.Point(-3, 113);
            this.lblProbe1.Name = "lblProbe1";
            this.lblProbe1.Size = new System.Drawing.Size(41, 13);
            this.lblProbe1.TabIndex = 33;
            this.lblProbe1.Text = "label14";
            // 
            // txtSchussStand1
            // 
            this.txtSchussStand1.AutoSize = true;
            this.txtSchussStand1.Location = new System.Drawing.Point(-3, 87);
            this.txtSchussStand1.Name = "txtSchussStand1";
            this.txtSchussStand1.Size = new System.Drawing.Size(0, 13);
            this.txtSchussStand1.TabIndex = 32;
            // 
            // lblSchussStand1
            // 
            this.lblSchussStand1.AutoSize = true;
            this.lblSchussStand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchussStand1.Location = new System.Drawing.Point(-3, 74);
            this.lblSchussStand1.Name = "lblSchussStand1";
            this.lblSchussStand1.Size = new System.Drawing.Size(51, 13);
            this.lblSchussStand1.TabIndex = 32;
            this.lblSchussStand1.Text = "Summe:";
            // 
            // txtDisziplinStand1
            // 
            this.txtDisziplinStand1.AutoSize = true;
            this.txtDisziplinStand1.Location = new System.Drawing.Point(-3, 39);
            this.txtDisziplinStand1.Name = "txtDisziplinStand1";
            this.txtDisziplinStand1.Size = new System.Drawing.Size(0, 13);
            this.txtDisziplinStand1.TabIndex = 32;
            // 
            // lblDisziplinStand1
            // 
            this.lblDisziplinStand1.AutoSize = true;
            this.lblDisziplinStand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisziplinStand1.Location = new System.Drawing.Point(-3, 26);
            this.lblDisziplinStand1.Name = "lblDisziplinStand1";
            this.lblDisziplinStand1.Size = new System.Drawing.Size(54, 13);
            this.lblDisziplinStand1.TabIndex = 32;
            this.lblDisziplinStand1.Text = "Disziplin";
            // 
            // txtSchuetzeStand1
            // 
            this.txtSchuetzeStand1.AutoSize = true;
            this.txtSchuetzeStand1.Location = new System.Drawing.Point(-3, 13);
            this.txtSchuetzeStand1.Name = "txtSchuetzeStand1";
            this.txtSchuetzeStand1.Size = new System.Drawing.Size(0, 13);
            this.txtSchuetzeStand1.TabIndex = 32;
            // 
            // lblSchuetzeStand1
            // 
            this.lblSchuetzeStand1.AutoSize = true;
            this.lblSchuetzeStand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchuetzeStand1.Location = new System.Drawing.Point(-3, 0);
            this.lblSchuetzeStand1.Name = "lblSchuetzeStand1";
            this.lblSchuetzeStand1.Size = new System.Drawing.Size(53, 13);
            this.lblSchuetzeStand1.TabIndex = 32;
            this.lblSchuetzeStand1.Text = "Schütze";
            // 
            // Stand1SchussPanel
            // 
            this.Stand1SchussPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Stand1SchussPanel.ColumnCount = 5;
            this.Stand1SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand1SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand1SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand1SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand1SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss100, 0, 0);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss110, 1, 0);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss120, 2, 0);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss130, 3, 0);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss140, 4, 0);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss101, 0, 1);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss111, 1, 1);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss121, 2, 1);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss131, 3, 1);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss141, 4, 1);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss102, 0, 2);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss112, 1, 2);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss122, 2, 2);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss132, 3, 2);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss142, 4, 2);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss103, 0, 3);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss113, 1, 3);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss123, 2, 3);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss133, 3, 3);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss143, 4, 3);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss104, 0, 4);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss114, 1, 4);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss124, 2, 4);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss134, 3, 4);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss144, 4, 4);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss105, 0, 5);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss115, 1, 5);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss125, 2, 5);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss135, 3, 5);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss145, 4, 5);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss106, 0, 6);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss116, 1, 6);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss126, 2, 6);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss136, 3, 6);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss146, 4, 6);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss107, 0, 7);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss117, 1, 7);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss127, 2, 7);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss137, 3, 7);
            this.Stand1SchussPanel.Controls.Add(this.txtSchuss147, 4, 7);
            this.Stand1SchussPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Stand1SchussPanel.Location = new System.Drawing.Point(0, 129);
            this.Stand1SchussPanel.Name = "Stand1SchussPanel";
            this.Stand1SchussPanel.RowCount = 8;
            this.Stand1SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand1SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand1SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand1SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand1SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand1SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand1SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand1SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand1SchussPanel.Size = new System.Drawing.Size(201, 70);
            this.Stand1SchussPanel.TabIndex = 6;
            // 
            // txtSchuss100
            // 
            this.txtSchuss100.AutoSize = true;
            this.txtSchuss100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss100.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss100.Location = new System.Drawing.Point(4, 1);
            this.txtSchuss100.Name = "txtSchuss100";
            this.txtSchuss100.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss100.TabIndex = 0;
            this.txtSchuss100.Text = "1";
            this.txtSchuss100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss110
            // 
            this.txtSchuss110.AutoSize = true;
            this.txtSchuss110.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss110.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss110.Location = new System.Drawing.Point(44, 1);
            this.txtSchuss110.Name = "txtSchuss110";
            this.txtSchuss110.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss110.TabIndex = 1;
            this.txtSchuss110.Text = "10";
            this.txtSchuss110.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss120
            // 
            this.txtSchuss120.AutoSize = true;
            this.txtSchuss120.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss120.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss120.Location = new System.Drawing.Point(84, 1);
            this.txtSchuss120.Name = "txtSchuss120";
            this.txtSchuss120.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss120.TabIndex = 0;
            this.txtSchuss120.Text = "1";
            this.txtSchuss120.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss130
            // 
            this.txtSchuss130.AutoSize = true;
            this.txtSchuss130.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss130.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss130.Location = new System.Drawing.Point(124, 1);
            this.txtSchuss130.Name = "txtSchuss130";
            this.txtSchuss130.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss130.TabIndex = 1;
            this.txtSchuss130.Text = "10";
            this.txtSchuss130.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss140
            // 
            this.txtSchuss140.AutoSize = true;
            this.txtSchuss140.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss140.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss140.Location = new System.Drawing.Point(164, 1);
            this.txtSchuss140.Name = "txtSchuss140";
            this.txtSchuss140.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss140.TabIndex = 0;
            this.txtSchuss140.Text = "1";
            this.txtSchuss140.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss101
            // 
            this.txtSchuss101.AutoSize = true;
            this.txtSchuss101.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss101.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss101.Location = new System.Drawing.Point(4, 9);
            this.txtSchuss101.Name = "txtSchuss101";
            this.txtSchuss101.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss101.TabIndex = 0;
            this.txtSchuss101.Text = "1";
            this.txtSchuss101.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss111
            // 
            this.txtSchuss111.AutoSize = true;
            this.txtSchuss111.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss111.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss111.Location = new System.Drawing.Point(44, 9);
            this.txtSchuss111.Name = "txtSchuss111";
            this.txtSchuss111.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss111.TabIndex = 1;
            this.txtSchuss111.Text = "10";
            this.txtSchuss111.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss121
            // 
            this.txtSchuss121.AutoSize = true;
            this.txtSchuss121.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss121.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss121.Location = new System.Drawing.Point(84, 9);
            this.txtSchuss121.Name = "txtSchuss121";
            this.txtSchuss121.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss121.TabIndex = 0;
            this.txtSchuss121.Text = "1";
            this.txtSchuss121.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss131
            // 
            this.txtSchuss131.AutoSize = true;
            this.txtSchuss131.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss131.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss131.Location = new System.Drawing.Point(124, 9);
            this.txtSchuss131.Name = "txtSchuss131";
            this.txtSchuss131.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss131.TabIndex = 1;
            this.txtSchuss131.Text = "10";
            this.txtSchuss131.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss141
            // 
            this.txtSchuss141.AutoSize = true;
            this.txtSchuss141.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss141.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss141.Location = new System.Drawing.Point(164, 9);
            this.txtSchuss141.Name = "txtSchuss141";
            this.txtSchuss141.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss141.TabIndex = 0;
            this.txtSchuss141.Text = "1";
            this.txtSchuss141.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss102
            // 
            this.txtSchuss102.AutoSize = true;
            this.txtSchuss102.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss102.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss102.Location = new System.Drawing.Point(4, 17);
            this.txtSchuss102.Name = "txtSchuss102";
            this.txtSchuss102.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss102.TabIndex = 0;
            this.txtSchuss102.Text = "1";
            this.txtSchuss102.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss112
            // 
            this.txtSchuss112.AutoSize = true;
            this.txtSchuss112.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss112.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss112.Location = new System.Drawing.Point(44, 17);
            this.txtSchuss112.Name = "txtSchuss112";
            this.txtSchuss112.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss112.TabIndex = 1;
            this.txtSchuss112.Text = "10";
            this.txtSchuss112.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss122
            // 
            this.txtSchuss122.AutoSize = true;
            this.txtSchuss122.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss122.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss122.Location = new System.Drawing.Point(84, 17);
            this.txtSchuss122.Name = "txtSchuss122";
            this.txtSchuss122.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss122.TabIndex = 0;
            this.txtSchuss122.Text = "1";
            this.txtSchuss122.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss132
            // 
            this.txtSchuss132.AutoSize = true;
            this.txtSchuss132.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss132.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss132.Location = new System.Drawing.Point(124, 17);
            this.txtSchuss132.Name = "txtSchuss132";
            this.txtSchuss132.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss132.TabIndex = 1;
            this.txtSchuss132.Text = "10";
            this.txtSchuss132.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss142
            // 
            this.txtSchuss142.AutoSize = true;
            this.txtSchuss142.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss142.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss142.Location = new System.Drawing.Point(164, 17);
            this.txtSchuss142.Name = "txtSchuss142";
            this.txtSchuss142.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss142.TabIndex = 0;
            this.txtSchuss142.Text = "1";
            this.txtSchuss142.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss103
            // 
            this.txtSchuss103.AutoSize = true;
            this.txtSchuss103.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss103.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss103.Location = new System.Drawing.Point(4, 25);
            this.txtSchuss103.Name = "txtSchuss103";
            this.txtSchuss103.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss103.TabIndex = 0;
            this.txtSchuss103.Text = "1";
            this.txtSchuss103.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss113
            // 
            this.txtSchuss113.AutoSize = true;
            this.txtSchuss113.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss113.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss113.Location = new System.Drawing.Point(44, 25);
            this.txtSchuss113.Name = "txtSchuss113";
            this.txtSchuss113.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss113.TabIndex = 1;
            this.txtSchuss113.Text = "10";
            this.txtSchuss113.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss123
            // 
            this.txtSchuss123.AutoSize = true;
            this.txtSchuss123.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss123.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss123.Location = new System.Drawing.Point(84, 25);
            this.txtSchuss123.Name = "txtSchuss123";
            this.txtSchuss123.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss123.TabIndex = 0;
            this.txtSchuss123.Text = "1";
            this.txtSchuss123.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss133
            // 
            this.txtSchuss133.AutoSize = true;
            this.txtSchuss133.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss133.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss133.Location = new System.Drawing.Point(124, 25);
            this.txtSchuss133.Name = "txtSchuss133";
            this.txtSchuss133.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss133.TabIndex = 1;
            this.txtSchuss133.Text = "10";
            this.txtSchuss133.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss143
            // 
            this.txtSchuss143.AutoSize = true;
            this.txtSchuss143.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss143.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss143.Location = new System.Drawing.Point(164, 25);
            this.txtSchuss143.Name = "txtSchuss143";
            this.txtSchuss143.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss143.TabIndex = 0;
            this.txtSchuss143.Text = "1";
            this.txtSchuss143.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss104
            // 
            this.txtSchuss104.AutoSize = true;
            this.txtSchuss104.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss104.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss104.Location = new System.Drawing.Point(4, 33);
            this.txtSchuss104.Name = "txtSchuss104";
            this.txtSchuss104.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss104.TabIndex = 0;
            this.txtSchuss104.Text = "1";
            this.txtSchuss104.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss114
            // 
            this.txtSchuss114.AutoSize = true;
            this.txtSchuss114.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss114.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss114.Location = new System.Drawing.Point(44, 33);
            this.txtSchuss114.Name = "txtSchuss114";
            this.txtSchuss114.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss114.TabIndex = 1;
            this.txtSchuss114.Text = "10";
            this.txtSchuss114.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss124
            // 
            this.txtSchuss124.AutoSize = true;
            this.txtSchuss124.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss124.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss124.Location = new System.Drawing.Point(84, 33);
            this.txtSchuss124.Name = "txtSchuss124";
            this.txtSchuss124.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss124.TabIndex = 0;
            this.txtSchuss124.Text = "1";
            this.txtSchuss124.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss134
            // 
            this.txtSchuss134.AutoSize = true;
            this.txtSchuss134.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss134.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss134.Location = new System.Drawing.Point(124, 33);
            this.txtSchuss134.Name = "txtSchuss134";
            this.txtSchuss134.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss134.TabIndex = 1;
            this.txtSchuss134.Text = "10";
            this.txtSchuss134.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss144
            // 
            this.txtSchuss144.AutoSize = true;
            this.txtSchuss144.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss144.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss144.Location = new System.Drawing.Point(164, 33);
            this.txtSchuss144.Name = "txtSchuss144";
            this.txtSchuss144.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss144.TabIndex = 0;
            this.txtSchuss144.Text = "1";
            this.txtSchuss144.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss105
            // 
            this.txtSchuss105.AutoSize = true;
            this.txtSchuss105.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss105.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss105.Location = new System.Drawing.Point(4, 41);
            this.txtSchuss105.Name = "txtSchuss105";
            this.txtSchuss105.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss105.TabIndex = 0;
            this.txtSchuss105.Text = "1";
            this.txtSchuss105.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss115
            // 
            this.txtSchuss115.AutoSize = true;
            this.txtSchuss115.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss115.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss115.Location = new System.Drawing.Point(44, 41);
            this.txtSchuss115.Name = "txtSchuss115";
            this.txtSchuss115.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss115.TabIndex = 1;
            this.txtSchuss115.Text = "10";
            this.txtSchuss115.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss125
            // 
            this.txtSchuss125.AutoSize = true;
            this.txtSchuss125.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss125.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss125.Location = new System.Drawing.Point(84, 41);
            this.txtSchuss125.Name = "txtSchuss125";
            this.txtSchuss125.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss125.TabIndex = 0;
            this.txtSchuss125.Text = "1";
            this.txtSchuss125.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss135
            // 
            this.txtSchuss135.AutoSize = true;
            this.txtSchuss135.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss135.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss135.Location = new System.Drawing.Point(124, 41);
            this.txtSchuss135.Name = "txtSchuss135";
            this.txtSchuss135.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss135.TabIndex = 1;
            this.txtSchuss135.Text = "10";
            this.txtSchuss135.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss145
            // 
            this.txtSchuss145.AutoSize = true;
            this.txtSchuss145.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss145.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss145.Location = new System.Drawing.Point(164, 41);
            this.txtSchuss145.Name = "txtSchuss145";
            this.txtSchuss145.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss145.TabIndex = 0;
            this.txtSchuss145.Text = "1";
            this.txtSchuss145.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss106
            // 
            this.txtSchuss106.AutoSize = true;
            this.txtSchuss106.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss106.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss106.Location = new System.Drawing.Point(4, 49);
            this.txtSchuss106.Name = "txtSchuss106";
            this.txtSchuss106.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss106.TabIndex = 0;
            this.txtSchuss106.Text = "1";
            this.txtSchuss106.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss116
            // 
            this.txtSchuss116.AutoSize = true;
            this.txtSchuss116.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss116.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss116.Location = new System.Drawing.Point(44, 49);
            this.txtSchuss116.Name = "txtSchuss116";
            this.txtSchuss116.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss116.TabIndex = 1;
            this.txtSchuss116.Text = "10";
            this.txtSchuss116.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss126
            // 
            this.txtSchuss126.AutoSize = true;
            this.txtSchuss126.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss126.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss126.Location = new System.Drawing.Point(84, 49);
            this.txtSchuss126.Name = "txtSchuss126";
            this.txtSchuss126.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss126.TabIndex = 0;
            this.txtSchuss126.Text = "1";
            this.txtSchuss126.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss136
            // 
            this.txtSchuss136.AutoSize = true;
            this.txtSchuss136.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss136.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss136.Location = new System.Drawing.Point(124, 49);
            this.txtSchuss136.Name = "txtSchuss136";
            this.txtSchuss136.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss136.TabIndex = 1;
            this.txtSchuss136.Text = "10";
            this.txtSchuss136.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss146
            // 
            this.txtSchuss146.AutoSize = true;
            this.txtSchuss146.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss146.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss146.Location = new System.Drawing.Point(164, 49);
            this.txtSchuss146.Name = "txtSchuss146";
            this.txtSchuss146.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss146.TabIndex = 0;
            this.txtSchuss146.Text = "1";
            this.txtSchuss146.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss107
            // 
            this.txtSchuss107.AutoSize = true;
            this.txtSchuss107.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss107.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss107.Location = new System.Drawing.Point(4, 57);
            this.txtSchuss107.Name = "txtSchuss107";
            this.txtSchuss107.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss107.TabIndex = 0;
            this.txtSchuss107.Text = "1";
            this.txtSchuss107.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss117
            // 
            this.txtSchuss117.AutoSize = true;
            this.txtSchuss117.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss117.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss117.Location = new System.Drawing.Point(44, 57);
            this.txtSchuss117.Name = "txtSchuss117";
            this.txtSchuss117.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss117.TabIndex = 1;
            this.txtSchuss117.Text = "10";
            this.txtSchuss117.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss127
            // 
            this.txtSchuss127.AutoSize = true;
            this.txtSchuss127.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss127.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss127.Location = new System.Drawing.Point(84, 57);
            this.txtSchuss127.Name = "txtSchuss127";
            this.txtSchuss127.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss127.TabIndex = 0;
            this.txtSchuss127.Text = "1";
            this.txtSchuss127.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss137
            // 
            this.txtSchuss137.AutoSize = true;
            this.txtSchuss137.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss137.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss137.Location = new System.Drawing.Point(124, 57);
            this.txtSchuss137.Name = "txtSchuss137";
            this.txtSchuss137.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss137.TabIndex = 1;
            this.txtSchuss137.Text = "10";
            this.txtSchuss137.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss147
            // 
            this.txtSchuss147.AutoSize = true;
            this.txtSchuss147.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss147.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss147.Location = new System.Drawing.Point(164, 57);
            this.txtSchuss147.Name = "txtSchuss147";
            this.txtSchuss147.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss147.TabIndex = 0;
            this.txtSchuss147.Text = "1";
            this.txtSchuss147.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Stand2SplitContainer
            // 
            this.Stand2SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stand2SplitContainer.Location = new System.Drawing.Point(322, 6);
            this.Stand2SplitContainer.Name = "Stand2SplitContainer";
            // 
            // Stand2SplitContainer.Panel1
            // 
            this.Stand2SplitContainer.Panel1.Controls.Add(this.stand2Zielscheibe);
            // 
            // Stand2SplitContainer.Panel2
            // 
            this.Stand2SplitContainer.Panel2.Controls.Add(this.lblProbe2);
            this.Stand2SplitContainer.Panel2.Controls.Add(this.txtSchussStand2);
            this.Stand2SplitContainer.Panel2.Controls.Add(this.lblSchussStand2);
            this.Stand2SplitContainer.Panel2.Controls.Add(this.txtDisziplinStand2);
            this.Stand2SplitContainer.Panel2.Controls.Add(this.lblDisziplinStand2);
            this.Stand2SplitContainer.Panel2.Controls.Add(this.txtSchuetzeStand2);
            this.Stand2SplitContainer.Panel2.Controls.Add(this.lblSchuetzeStand2);
            this.Stand2SplitContainer.Panel2.Controls.Add(this.Stand2SchussPanel);
            this.Stand2SplitContainer.Size = new System.Drawing.Size(307, 199);
            this.Stand2SplitContainer.SplitterDistance = 102;
            this.Stand2SplitContainer.TabIndex = 2;
            // 
            // stand2Zielscheibe
            // 
            this.stand2Zielscheibe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stand2Zielscheibe.Location = new System.Drawing.Point(0, 0);
            this.stand2Zielscheibe.Name = "stand2Zielscheibe";
            this.stand2Zielscheibe.Size = new System.Drawing.Size(102, 199);
            this.stand2Zielscheibe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stand2Zielscheibe.TabIndex = 1;
            this.stand2Zielscheibe.TabStop = false;
            this.stand2Zielscheibe.Paint += new System.Windows.Forms.PaintEventHandler(this.stand2Zielscheibe_Paint);
            this.stand2Zielscheibe.DoubleClick += new System.EventHandler(this.stand2Zielscheibe_DoubleClick);
            // 
            // lblProbe2
            // 
            this.lblProbe2.AutoSize = true;
            this.lblProbe2.Location = new System.Drawing.Point(-3, 113);
            this.lblProbe2.Name = "lblProbe2";
            this.lblProbe2.Size = new System.Drawing.Size(41, 13);
            this.lblProbe2.TabIndex = 38;
            this.lblProbe2.Text = "label19";
            // 
            // txtSchussStand2
            // 
            this.txtSchussStand2.AutoSize = true;
            this.txtSchussStand2.Location = new System.Drawing.Point(-3, 87);
            this.txtSchussStand2.Name = "txtSchussStand2";
            this.txtSchussStand2.Size = new System.Drawing.Size(0, 13);
            this.txtSchussStand2.TabIndex = 32;
            // 
            // lblSchussStand2
            // 
            this.lblSchussStand2.AutoSize = true;
            this.lblSchussStand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchussStand2.Location = new System.Drawing.Point(-3, 74);
            this.lblSchussStand2.Name = "lblSchussStand2";
            this.lblSchussStand2.Size = new System.Drawing.Size(51, 13);
            this.lblSchussStand2.TabIndex = 32;
            this.lblSchussStand2.Text = "Summe:";
            // 
            // txtDisziplinStand2
            // 
            this.txtDisziplinStand2.AutoSize = true;
            this.txtDisziplinStand2.Location = new System.Drawing.Point(-3, 39);
            this.txtDisziplinStand2.Name = "txtDisziplinStand2";
            this.txtDisziplinStand2.Size = new System.Drawing.Size(0, 13);
            this.txtDisziplinStand2.TabIndex = 32;
            // 
            // lblDisziplinStand2
            // 
            this.lblDisziplinStand2.AutoSize = true;
            this.lblDisziplinStand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisziplinStand2.Location = new System.Drawing.Point(-3, 26);
            this.lblDisziplinStand2.Name = "lblDisziplinStand2";
            this.lblDisziplinStand2.Size = new System.Drawing.Size(54, 13);
            this.lblDisziplinStand2.TabIndex = 32;
            this.lblDisziplinStand2.Text = "Disziplin";
            // 
            // txtSchuetzeStand2
            // 
            this.txtSchuetzeStand2.AutoSize = true;
            this.txtSchuetzeStand2.Location = new System.Drawing.Point(-3, 13);
            this.txtSchuetzeStand2.Name = "txtSchuetzeStand2";
            this.txtSchuetzeStand2.Size = new System.Drawing.Size(0, 13);
            this.txtSchuetzeStand2.TabIndex = 32;
            // 
            // lblSchuetzeStand2
            // 
            this.lblSchuetzeStand2.AutoSize = true;
            this.lblSchuetzeStand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchuetzeStand2.Location = new System.Drawing.Point(-3, 0);
            this.lblSchuetzeStand2.Name = "lblSchuetzeStand2";
            this.lblSchuetzeStand2.Size = new System.Drawing.Size(53, 13);
            this.lblSchuetzeStand2.TabIndex = 32;
            this.lblSchuetzeStand2.Text = "Schütze";
            // 
            // Stand2SchussPanel
            // 
            this.Stand2SchussPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Stand2SchussPanel.ColumnCount = 5;
            this.Stand2SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand2SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand2SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand2SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand2SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss200, 0, 0);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss210, 1, 0);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss220, 2, 0);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss230, 3, 0);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss240, 4, 0);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss201, 0, 1);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss211, 1, 1);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss221, 2, 1);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss231, 3, 1);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss241, 4, 1);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss202, 0, 2);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss212, 1, 2);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss222, 2, 2);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss232, 3, 2);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss242, 4, 2);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss203, 0, 3);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss213, 1, 3);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss223, 2, 3);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss233, 3, 3);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss243, 4, 3);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss204, 0, 4);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss214, 1, 4);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss224, 2, 4);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss234, 3, 4);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss244, 4, 4);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss205, 0, 5);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss215, 1, 5);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss225, 2, 5);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss235, 3, 5);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss245, 4, 5);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss206, 0, 6);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss216, 1, 6);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss226, 2, 6);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss236, 3, 6);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss246, 4, 6);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss207, 0, 7);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss217, 1, 7);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss227, 2, 7);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss237, 3, 7);
            this.Stand2SchussPanel.Controls.Add(this.txtSchuss247, 4, 7);
            this.Stand2SchussPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Stand2SchussPanel.Location = new System.Drawing.Point(0, 129);
            this.Stand2SchussPanel.Name = "Stand2SchussPanel";
            this.Stand2SchussPanel.RowCount = 8;
            this.Stand2SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand2SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand2SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand2SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand2SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand2SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand2SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand2SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand2SchussPanel.Size = new System.Drawing.Size(201, 70);
            this.Stand2SchussPanel.TabIndex = 6;
            // 
            // txtSchuss200
            // 
            this.txtSchuss200.AutoSize = true;
            this.txtSchuss200.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss200.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss200.Location = new System.Drawing.Point(4, 1);
            this.txtSchuss200.Name = "txtSchuss200";
            this.txtSchuss200.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss200.TabIndex = 0;
            this.txtSchuss200.Text = "1";
            this.txtSchuss200.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss210
            // 
            this.txtSchuss210.AutoSize = true;
            this.txtSchuss210.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss210.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss210.Location = new System.Drawing.Point(44, 1);
            this.txtSchuss210.Name = "txtSchuss210";
            this.txtSchuss210.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss210.TabIndex = 1;
            this.txtSchuss210.Text = "10";
            this.txtSchuss210.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss220
            // 
            this.txtSchuss220.AutoSize = true;
            this.txtSchuss220.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss220.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss220.Location = new System.Drawing.Point(84, 1);
            this.txtSchuss220.Name = "txtSchuss220";
            this.txtSchuss220.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss220.TabIndex = 0;
            this.txtSchuss220.Text = "1";
            this.txtSchuss220.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss230
            // 
            this.txtSchuss230.AutoSize = true;
            this.txtSchuss230.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss230.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss230.Location = new System.Drawing.Point(124, 1);
            this.txtSchuss230.Name = "txtSchuss230";
            this.txtSchuss230.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss230.TabIndex = 1;
            this.txtSchuss230.Text = "10";
            this.txtSchuss230.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss240
            // 
            this.txtSchuss240.AutoSize = true;
            this.txtSchuss240.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss240.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss240.Location = new System.Drawing.Point(164, 1);
            this.txtSchuss240.Name = "txtSchuss240";
            this.txtSchuss240.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss240.TabIndex = 0;
            this.txtSchuss240.Text = "1";
            this.txtSchuss240.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss201
            // 
            this.txtSchuss201.AutoSize = true;
            this.txtSchuss201.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss201.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss201.Location = new System.Drawing.Point(4, 9);
            this.txtSchuss201.Name = "txtSchuss201";
            this.txtSchuss201.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss201.TabIndex = 0;
            this.txtSchuss201.Text = "1";
            this.txtSchuss201.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss211
            // 
            this.txtSchuss211.AutoSize = true;
            this.txtSchuss211.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss211.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss211.Location = new System.Drawing.Point(44, 9);
            this.txtSchuss211.Name = "txtSchuss211";
            this.txtSchuss211.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss211.TabIndex = 1;
            this.txtSchuss211.Text = "10";
            this.txtSchuss211.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss221
            // 
            this.txtSchuss221.AutoSize = true;
            this.txtSchuss221.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss221.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss221.Location = new System.Drawing.Point(84, 9);
            this.txtSchuss221.Name = "txtSchuss221";
            this.txtSchuss221.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss221.TabIndex = 0;
            this.txtSchuss221.Text = "1";
            this.txtSchuss221.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss231
            // 
            this.txtSchuss231.AutoSize = true;
            this.txtSchuss231.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss231.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss231.Location = new System.Drawing.Point(124, 9);
            this.txtSchuss231.Name = "txtSchuss231";
            this.txtSchuss231.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss231.TabIndex = 1;
            this.txtSchuss231.Text = "10";
            this.txtSchuss231.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss241
            // 
            this.txtSchuss241.AutoSize = true;
            this.txtSchuss241.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss241.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss241.Location = new System.Drawing.Point(164, 9);
            this.txtSchuss241.Name = "txtSchuss241";
            this.txtSchuss241.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss241.TabIndex = 0;
            this.txtSchuss241.Text = "1";
            this.txtSchuss241.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss202
            // 
            this.txtSchuss202.AutoSize = true;
            this.txtSchuss202.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss202.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss202.Location = new System.Drawing.Point(4, 17);
            this.txtSchuss202.Name = "txtSchuss202";
            this.txtSchuss202.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss202.TabIndex = 0;
            this.txtSchuss202.Text = "1";
            this.txtSchuss202.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss212
            // 
            this.txtSchuss212.AutoSize = true;
            this.txtSchuss212.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss212.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss212.Location = new System.Drawing.Point(44, 17);
            this.txtSchuss212.Name = "txtSchuss212";
            this.txtSchuss212.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss212.TabIndex = 1;
            this.txtSchuss212.Text = "10";
            this.txtSchuss212.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss222
            // 
            this.txtSchuss222.AutoSize = true;
            this.txtSchuss222.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss222.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss222.Location = new System.Drawing.Point(84, 17);
            this.txtSchuss222.Name = "txtSchuss222";
            this.txtSchuss222.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss222.TabIndex = 0;
            this.txtSchuss222.Text = "1";
            this.txtSchuss222.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss232
            // 
            this.txtSchuss232.AutoSize = true;
            this.txtSchuss232.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss232.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss232.Location = new System.Drawing.Point(124, 17);
            this.txtSchuss232.Name = "txtSchuss232";
            this.txtSchuss232.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss232.TabIndex = 1;
            this.txtSchuss232.Text = "10";
            this.txtSchuss232.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss242
            // 
            this.txtSchuss242.AutoSize = true;
            this.txtSchuss242.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss242.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss242.Location = new System.Drawing.Point(164, 17);
            this.txtSchuss242.Name = "txtSchuss242";
            this.txtSchuss242.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss242.TabIndex = 0;
            this.txtSchuss242.Text = "1";
            this.txtSchuss242.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss203
            // 
            this.txtSchuss203.AutoSize = true;
            this.txtSchuss203.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss203.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss203.Location = new System.Drawing.Point(4, 25);
            this.txtSchuss203.Name = "txtSchuss203";
            this.txtSchuss203.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss203.TabIndex = 0;
            this.txtSchuss203.Text = "1";
            this.txtSchuss203.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss213
            // 
            this.txtSchuss213.AutoSize = true;
            this.txtSchuss213.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss213.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss213.Location = new System.Drawing.Point(44, 25);
            this.txtSchuss213.Name = "txtSchuss213";
            this.txtSchuss213.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss213.TabIndex = 1;
            this.txtSchuss213.Text = "10";
            this.txtSchuss213.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss223
            // 
            this.txtSchuss223.AutoSize = true;
            this.txtSchuss223.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss223.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss223.Location = new System.Drawing.Point(84, 25);
            this.txtSchuss223.Name = "txtSchuss223";
            this.txtSchuss223.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss223.TabIndex = 0;
            this.txtSchuss223.Text = "1";
            this.txtSchuss223.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss233
            // 
            this.txtSchuss233.AutoSize = true;
            this.txtSchuss233.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss233.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss233.Location = new System.Drawing.Point(124, 25);
            this.txtSchuss233.Name = "txtSchuss233";
            this.txtSchuss233.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss233.TabIndex = 1;
            this.txtSchuss233.Text = "10";
            this.txtSchuss233.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss243
            // 
            this.txtSchuss243.AutoSize = true;
            this.txtSchuss243.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss243.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss243.Location = new System.Drawing.Point(164, 25);
            this.txtSchuss243.Name = "txtSchuss243";
            this.txtSchuss243.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss243.TabIndex = 0;
            this.txtSchuss243.Text = "1";
            this.txtSchuss243.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss204
            // 
            this.txtSchuss204.AutoSize = true;
            this.txtSchuss204.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss204.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss204.Location = new System.Drawing.Point(4, 33);
            this.txtSchuss204.Name = "txtSchuss204";
            this.txtSchuss204.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss204.TabIndex = 0;
            this.txtSchuss204.Text = "1";
            this.txtSchuss204.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss214
            // 
            this.txtSchuss214.AutoSize = true;
            this.txtSchuss214.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss214.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss214.Location = new System.Drawing.Point(44, 33);
            this.txtSchuss214.Name = "txtSchuss214";
            this.txtSchuss214.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss214.TabIndex = 1;
            this.txtSchuss214.Text = "10";
            this.txtSchuss214.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss224
            // 
            this.txtSchuss224.AutoSize = true;
            this.txtSchuss224.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss224.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss224.Location = new System.Drawing.Point(84, 33);
            this.txtSchuss224.Name = "txtSchuss224";
            this.txtSchuss224.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss224.TabIndex = 0;
            this.txtSchuss224.Text = "1";
            this.txtSchuss224.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss234
            // 
            this.txtSchuss234.AutoSize = true;
            this.txtSchuss234.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss234.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss234.Location = new System.Drawing.Point(124, 33);
            this.txtSchuss234.Name = "txtSchuss234";
            this.txtSchuss234.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss234.TabIndex = 1;
            this.txtSchuss234.Text = "10";
            this.txtSchuss234.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss244
            // 
            this.txtSchuss244.AutoSize = true;
            this.txtSchuss244.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss244.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss244.Location = new System.Drawing.Point(164, 33);
            this.txtSchuss244.Name = "txtSchuss244";
            this.txtSchuss244.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss244.TabIndex = 0;
            this.txtSchuss244.Text = "1";
            this.txtSchuss244.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss205
            // 
            this.txtSchuss205.AutoSize = true;
            this.txtSchuss205.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss205.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss205.Location = new System.Drawing.Point(4, 41);
            this.txtSchuss205.Name = "txtSchuss205";
            this.txtSchuss205.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss205.TabIndex = 0;
            this.txtSchuss205.Text = "1";
            this.txtSchuss205.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss215
            // 
            this.txtSchuss215.AutoSize = true;
            this.txtSchuss215.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss215.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss215.Location = new System.Drawing.Point(44, 41);
            this.txtSchuss215.Name = "txtSchuss215";
            this.txtSchuss215.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss215.TabIndex = 1;
            this.txtSchuss215.Text = "10";
            this.txtSchuss215.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss225
            // 
            this.txtSchuss225.AutoSize = true;
            this.txtSchuss225.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss225.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss225.Location = new System.Drawing.Point(84, 41);
            this.txtSchuss225.Name = "txtSchuss225";
            this.txtSchuss225.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss225.TabIndex = 0;
            this.txtSchuss225.Text = "1";
            this.txtSchuss225.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss235
            // 
            this.txtSchuss235.AutoSize = true;
            this.txtSchuss235.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss235.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss235.Location = new System.Drawing.Point(124, 41);
            this.txtSchuss235.Name = "txtSchuss235";
            this.txtSchuss235.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss235.TabIndex = 1;
            this.txtSchuss235.Text = "10";
            this.txtSchuss235.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss245
            // 
            this.txtSchuss245.AutoSize = true;
            this.txtSchuss245.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss245.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss245.Location = new System.Drawing.Point(164, 41);
            this.txtSchuss245.Name = "txtSchuss245";
            this.txtSchuss245.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss245.TabIndex = 0;
            this.txtSchuss245.Text = "1";
            this.txtSchuss245.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss206
            // 
            this.txtSchuss206.AutoSize = true;
            this.txtSchuss206.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss206.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss206.Location = new System.Drawing.Point(4, 49);
            this.txtSchuss206.Name = "txtSchuss206";
            this.txtSchuss206.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss206.TabIndex = 0;
            this.txtSchuss206.Text = "1";
            this.txtSchuss206.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss216
            // 
            this.txtSchuss216.AutoSize = true;
            this.txtSchuss216.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss216.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss216.Location = new System.Drawing.Point(44, 49);
            this.txtSchuss216.Name = "txtSchuss216";
            this.txtSchuss216.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss216.TabIndex = 1;
            this.txtSchuss216.Text = "10";
            this.txtSchuss216.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss226
            // 
            this.txtSchuss226.AutoSize = true;
            this.txtSchuss226.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss226.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss226.Location = new System.Drawing.Point(84, 49);
            this.txtSchuss226.Name = "txtSchuss226";
            this.txtSchuss226.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss226.TabIndex = 0;
            this.txtSchuss226.Text = "1";
            this.txtSchuss226.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss236
            // 
            this.txtSchuss236.AutoSize = true;
            this.txtSchuss236.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss236.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss236.Location = new System.Drawing.Point(124, 49);
            this.txtSchuss236.Name = "txtSchuss236";
            this.txtSchuss236.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss236.TabIndex = 1;
            this.txtSchuss236.Text = "10";
            this.txtSchuss236.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss246
            // 
            this.txtSchuss246.AutoSize = true;
            this.txtSchuss246.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss246.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss246.Location = new System.Drawing.Point(164, 49);
            this.txtSchuss246.Name = "txtSchuss246";
            this.txtSchuss246.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss246.TabIndex = 0;
            this.txtSchuss246.Text = "1";
            this.txtSchuss246.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss207
            // 
            this.txtSchuss207.AutoSize = true;
            this.txtSchuss207.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss207.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss207.Location = new System.Drawing.Point(4, 57);
            this.txtSchuss207.Name = "txtSchuss207";
            this.txtSchuss207.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss207.TabIndex = 0;
            this.txtSchuss207.Text = "1";
            this.txtSchuss207.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss217
            // 
            this.txtSchuss217.AutoSize = true;
            this.txtSchuss217.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss217.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss217.Location = new System.Drawing.Point(44, 57);
            this.txtSchuss217.Name = "txtSchuss217";
            this.txtSchuss217.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss217.TabIndex = 1;
            this.txtSchuss217.Text = "10";
            this.txtSchuss217.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss227
            // 
            this.txtSchuss227.AutoSize = true;
            this.txtSchuss227.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss227.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss227.Location = new System.Drawing.Point(84, 57);
            this.txtSchuss227.Name = "txtSchuss227";
            this.txtSchuss227.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss227.TabIndex = 0;
            this.txtSchuss227.Text = "1";
            this.txtSchuss227.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss237
            // 
            this.txtSchuss237.AutoSize = true;
            this.txtSchuss237.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss237.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss237.Location = new System.Drawing.Point(124, 57);
            this.txtSchuss237.Name = "txtSchuss237";
            this.txtSchuss237.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss237.TabIndex = 1;
            this.txtSchuss237.Text = "10";
            this.txtSchuss237.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss247
            // 
            this.txtSchuss247.AutoSize = true;
            this.txtSchuss247.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss247.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss247.Location = new System.Drawing.Point(164, 57);
            this.txtSchuss247.Name = "txtSchuss247";
            this.txtSchuss247.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss247.TabIndex = 0;
            this.txtSchuss247.Text = "1";
            this.txtSchuss247.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Stand3SplitContainer
            // 
            this.Stand3SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stand3SplitContainer.Location = new System.Drawing.Point(638, 6);
            this.Stand3SplitContainer.Name = "Stand3SplitContainer";
            // 
            // Stand3SplitContainer.Panel1
            // 
            this.Stand3SplitContainer.Panel1.Controls.Add(this.stand3Zielscheibe);
            // 
            // Stand3SplitContainer.Panel2
            // 
            this.Stand3SplitContainer.Panel2.Controls.Add(this.lblProbe3);
            this.Stand3SplitContainer.Panel2.Controls.Add(this.txtSchussStand3);
            this.Stand3SplitContainer.Panel2.Controls.Add(this.lblSchussStand3);
            this.Stand3SplitContainer.Panel2.Controls.Add(this.txtDisziplinStand3);
            this.Stand3SplitContainer.Panel2.Controls.Add(this.lblDisziplinStand3);
            this.Stand3SplitContainer.Panel2.Controls.Add(this.txtSchuetzeStand3);
            this.Stand3SplitContainer.Panel2.Controls.Add(this.lblSchuetzeStand3);
            this.Stand3SplitContainer.Panel2.Controls.Add(this.Stand3SchussPanel);
            this.Stand3SplitContainer.Size = new System.Drawing.Size(308, 199);
            this.Stand3SplitContainer.SplitterDistance = 102;
            this.Stand3SplitContainer.TabIndex = 2;
            // 
            // stand3Zielscheibe
            // 
            this.stand3Zielscheibe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stand3Zielscheibe.Location = new System.Drawing.Point(0, 0);
            this.stand3Zielscheibe.Name = "stand3Zielscheibe";
            this.stand3Zielscheibe.Size = new System.Drawing.Size(102, 199);
            this.stand3Zielscheibe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stand3Zielscheibe.TabIndex = 1;
            this.stand3Zielscheibe.TabStop = false;
            this.stand3Zielscheibe.Paint += new System.Windows.Forms.PaintEventHandler(this.stand3Zielscheibe_Paint);
            this.stand3Zielscheibe.DoubleClick += new System.EventHandler(this.stand3Zielscheibe_DoubleClick);
            // 
            // lblProbe3
            // 
            this.lblProbe3.AutoSize = true;
            this.lblProbe3.Location = new System.Drawing.Point(-3, 113);
            this.lblProbe3.Name = "lblProbe3";
            this.lblProbe3.Size = new System.Drawing.Size(41, 13);
            this.lblProbe3.TabIndex = 37;
            this.lblProbe3.Text = "label18";
            // 
            // txtSchussStand3
            // 
            this.txtSchussStand3.AutoSize = true;
            this.txtSchussStand3.Location = new System.Drawing.Point(-3, 87);
            this.txtSchussStand3.Name = "txtSchussStand3";
            this.txtSchussStand3.Size = new System.Drawing.Size(0, 13);
            this.txtSchussStand3.TabIndex = 32;
            // 
            // lblSchussStand3
            // 
            this.lblSchussStand3.AutoSize = true;
            this.lblSchussStand3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchussStand3.Location = new System.Drawing.Point(-3, 74);
            this.lblSchussStand3.Name = "lblSchussStand3";
            this.lblSchussStand3.Size = new System.Drawing.Size(51, 13);
            this.lblSchussStand3.TabIndex = 32;
            this.lblSchussStand3.Text = "Summe:";
            // 
            // txtDisziplinStand3
            // 
            this.txtDisziplinStand3.AutoSize = true;
            this.txtDisziplinStand3.Location = new System.Drawing.Point(-3, 39);
            this.txtDisziplinStand3.Name = "txtDisziplinStand3";
            this.txtDisziplinStand3.Size = new System.Drawing.Size(0, 13);
            this.txtDisziplinStand3.TabIndex = 32;
            // 
            // lblDisziplinStand3
            // 
            this.lblDisziplinStand3.AutoSize = true;
            this.lblDisziplinStand3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisziplinStand3.Location = new System.Drawing.Point(-3, 26);
            this.lblDisziplinStand3.Name = "lblDisziplinStand3";
            this.lblDisziplinStand3.Size = new System.Drawing.Size(54, 13);
            this.lblDisziplinStand3.TabIndex = 32;
            this.lblDisziplinStand3.Text = "Disziplin";
            // 
            // txtSchuetzeStand3
            // 
            this.txtSchuetzeStand3.AutoSize = true;
            this.txtSchuetzeStand3.Location = new System.Drawing.Point(-3, 13);
            this.txtSchuetzeStand3.Name = "txtSchuetzeStand3";
            this.txtSchuetzeStand3.Size = new System.Drawing.Size(0, 13);
            this.txtSchuetzeStand3.TabIndex = 32;
            // 
            // lblSchuetzeStand3
            // 
            this.lblSchuetzeStand3.AutoSize = true;
            this.lblSchuetzeStand3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchuetzeStand3.Location = new System.Drawing.Point(-3, 0);
            this.lblSchuetzeStand3.Name = "lblSchuetzeStand3";
            this.lblSchuetzeStand3.Size = new System.Drawing.Size(53, 13);
            this.lblSchuetzeStand3.TabIndex = 32;
            this.lblSchuetzeStand3.Text = "Schütze";
            // 
            // Stand3SchussPanel
            // 
            this.Stand3SchussPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Stand3SchussPanel.ColumnCount = 5;
            this.Stand3SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand3SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand3SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand3SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand3SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss300, 0, 0);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss310, 1, 0);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss320, 2, 0);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss330, 3, 0);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss340, 4, 0);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss301, 0, 1);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss311, 1, 1);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss321, 2, 1);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss331, 3, 1);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss341, 4, 1);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss302, 0, 2);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss312, 1, 2);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss322, 2, 2);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss332, 3, 2);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss342, 4, 2);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss303, 0, 3);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss313, 1, 3);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss323, 2, 3);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss333, 3, 3);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss343, 4, 3);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss304, 0, 4);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss314, 1, 4);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss324, 2, 4);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss334, 3, 4);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss344, 4, 4);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss305, 0, 5);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss315, 1, 5);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss325, 2, 5);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss335, 3, 5);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss345, 4, 5);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss306, 0, 6);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss316, 1, 6);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss326, 2, 6);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss336, 3, 6);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss346, 4, 6);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss307, 0, 7);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss317, 1, 7);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss327, 2, 7);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss337, 3, 7);
            this.Stand3SchussPanel.Controls.Add(this.txtSchuss347, 4, 7);
            this.Stand3SchussPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Stand3SchussPanel.Location = new System.Drawing.Point(0, 129);
            this.Stand3SchussPanel.Name = "Stand3SchussPanel";
            this.Stand3SchussPanel.RowCount = 8;
            this.Stand3SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand3SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand3SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand3SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand3SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand3SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand3SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand3SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand3SchussPanel.Size = new System.Drawing.Size(202, 70);
            this.Stand3SchussPanel.TabIndex = 6;
            // 
            // txtSchuss300
            // 
            this.txtSchuss300.AutoSize = true;
            this.txtSchuss300.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss300.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss300.Location = new System.Drawing.Point(4, 1);
            this.txtSchuss300.Name = "txtSchuss300";
            this.txtSchuss300.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss300.TabIndex = 0;
            this.txtSchuss300.Text = "1";
            this.txtSchuss300.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss310
            // 
            this.txtSchuss310.AutoSize = true;
            this.txtSchuss310.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss310.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss310.Location = new System.Drawing.Point(44, 1);
            this.txtSchuss310.Name = "txtSchuss310";
            this.txtSchuss310.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss310.TabIndex = 1;
            this.txtSchuss310.Text = "10";
            this.txtSchuss310.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss320
            // 
            this.txtSchuss320.AutoSize = true;
            this.txtSchuss320.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss320.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss320.Location = new System.Drawing.Point(84, 1);
            this.txtSchuss320.Name = "txtSchuss320";
            this.txtSchuss320.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss320.TabIndex = 0;
            this.txtSchuss320.Text = "1";
            this.txtSchuss320.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss330
            // 
            this.txtSchuss330.AutoSize = true;
            this.txtSchuss330.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss330.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss330.Location = new System.Drawing.Point(124, 1);
            this.txtSchuss330.Name = "txtSchuss330";
            this.txtSchuss330.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss330.TabIndex = 1;
            this.txtSchuss330.Text = "10";
            this.txtSchuss330.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss340
            // 
            this.txtSchuss340.AutoSize = true;
            this.txtSchuss340.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss340.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss340.Location = new System.Drawing.Point(164, 1);
            this.txtSchuss340.Name = "txtSchuss340";
            this.txtSchuss340.Size = new System.Drawing.Size(34, 7);
            this.txtSchuss340.TabIndex = 0;
            this.txtSchuss340.Text = "1";
            this.txtSchuss340.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss301
            // 
            this.txtSchuss301.AutoSize = true;
            this.txtSchuss301.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss301.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss301.Location = new System.Drawing.Point(4, 9);
            this.txtSchuss301.Name = "txtSchuss301";
            this.txtSchuss301.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss301.TabIndex = 0;
            this.txtSchuss301.Text = "1";
            this.txtSchuss301.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss311
            // 
            this.txtSchuss311.AutoSize = true;
            this.txtSchuss311.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss311.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss311.Location = new System.Drawing.Point(44, 9);
            this.txtSchuss311.Name = "txtSchuss311";
            this.txtSchuss311.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss311.TabIndex = 1;
            this.txtSchuss311.Text = "10";
            this.txtSchuss311.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss321
            // 
            this.txtSchuss321.AutoSize = true;
            this.txtSchuss321.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss321.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss321.Location = new System.Drawing.Point(84, 9);
            this.txtSchuss321.Name = "txtSchuss321";
            this.txtSchuss321.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss321.TabIndex = 0;
            this.txtSchuss321.Text = "1";
            this.txtSchuss321.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss331
            // 
            this.txtSchuss331.AutoSize = true;
            this.txtSchuss331.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss331.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss331.Location = new System.Drawing.Point(124, 9);
            this.txtSchuss331.Name = "txtSchuss331";
            this.txtSchuss331.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss331.TabIndex = 1;
            this.txtSchuss331.Text = "10";
            this.txtSchuss331.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss341
            // 
            this.txtSchuss341.AutoSize = true;
            this.txtSchuss341.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss341.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss341.Location = new System.Drawing.Point(164, 9);
            this.txtSchuss341.Name = "txtSchuss341";
            this.txtSchuss341.Size = new System.Drawing.Size(34, 7);
            this.txtSchuss341.TabIndex = 0;
            this.txtSchuss341.Text = "1";
            this.txtSchuss341.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss302
            // 
            this.txtSchuss302.AutoSize = true;
            this.txtSchuss302.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss302.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss302.Location = new System.Drawing.Point(4, 17);
            this.txtSchuss302.Name = "txtSchuss302";
            this.txtSchuss302.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss302.TabIndex = 0;
            this.txtSchuss302.Text = "1";
            this.txtSchuss302.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss312
            // 
            this.txtSchuss312.AutoSize = true;
            this.txtSchuss312.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss312.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss312.Location = new System.Drawing.Point(44, 17);
            this.txtSchuss312.Name = "txtSchuss312";
            this.txtSchuss312.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss312.TabIndex = 1;
            this.txtSchuss312.Text = "10";
            this.txtSchuss312.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss322
            // 
            this.txtSchuss322.AutoSize = true;
            this.txtSchuss322.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss322.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss322.Location = new System.Drawing.Point(84, 17);
            this.txtSchuss322.Name = "txtSchuss322";
            this.txtSchuss322.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss322.TabIndex = 0;
            this.txtSchuss322.Text = "1";
            this.txtSchuss322.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss332
            // 
            this.txtSchuss332.AutoSize = true;
            this.txtSchuss332.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss332.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss332.Location = new System.Drawing.Point(124, 17);
            this.txtSchuss332.Name = "txtSchuss332";
            this.txtSchuss332.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss332.TabIndex = 1;
            this.txtSchuss332.Text = "10";
            this.txtSchuss332.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss342
            // 
            this.txtSchuss342.AutoSize = true;
            this.txtSchuss342.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss342.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss342.Location = new System.Drawing.Point(164, 17);
            this.txtSchuss342.Name = "txtSchuss342";
            this.txtSchuss342.Size = new System.Drawing.Size(34, 7);
            this.txtSchuss342.TabIndex = 0;
            this.txtSchuss342.Text = "1";
            this.txtSchuss342.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss303
            // 
            this.txtSchuss303.AutoSize = true;
            this.txtSchuss303.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss303.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss303.Location = new System.Drawing.Point(4, 25);
            this.txtSchuss303.Name = "txtSchuss303";
            this.txtSchuss303.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss303.TabIndex = 0;
            this.txtSchuss303.Text = "1";
            this.txtSchuss303.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss313
            // 
            this.txtSchuss313.AutoSize = true;
            this.txtSchuss313.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss313.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss313.Location = new System.Drawing.Point(44, 25);
            this.txtSchuss313.Name = "txtSchuss313";
            this.txtSchuss313.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss313.TabIndex = 1;
            this.txtSchuss313.Text = "10";
            this.txtSchuss313.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss323
            // 
            this.txtSchuss323.AutoSize = true;
            this.txtSchuss323.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss323.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss323.Location = new System.Drawing.Point(84, 25);
            this.txtSchuss323.Name = "txtSchuss323";
            this.txtSchuss323.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss323.TabIndex = 0;
            this.txtSchuss323.Text = "1";
            this.txtSchuss323.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss333
            // 
            this.txtSchuss333.AutoSize = true;
            this.txtSchuss333.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss333.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss333.Location = new System.Drawing.Point(124, 25);
            this.txtSchuss333.Name = "txtSchuss333";
            this.txtSchuss333.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss333.TabIndex = 1;
            this.txtSchuss333.Text = "10";
            this.txtSchuss333.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss343
            // 
            this.txtSchuss343.AutoSize = true;
            this.txtSchuss343.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss343.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss343.Location = new System.Drawing.Point(164, 25);
            this.txtSchuss343.Name = "txtSchuss343";
            this.txtSchuss343.Size = new System.Drawing.Size(34, 7);
            this.txtSchuss343.TabIndex = 0;
            this.txtSchuss343.Text = "1";
            this.txtSchuss343.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss304
            // 
            this.txtSchuss304.AutoSize = true;
            this.txtSchuss304.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss304.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss304.Location = new System.Drawing.Point(4, 33);
            this.txtSchuss304.Name = "txtSchuss304";
            this.txtSchuss304.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss304.TabIndex = 0;
            this.txtSchuss304.Text = "1";
            this.txtSchuss304.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss314
            // 
            this.txtSchuss314.AutoSize = true;
            this.txtSchuss314.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss314.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss314.Location = new System.Drawing.Point(44, 33);
            this.txtSchuss314.Name = "txtSchuss314";
            this.txtSchuss314.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss314.TabIndex = 1;
            this.txtSchuss314.Text = "10";
            this.txtSchuss314.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss324
            // 
            this.txtSchuss324.AutoSize = true;
            this.txtSchuss324.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss324.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss324.Location = new System.Drawing.Point(84, 33);
            this.txtSchuss324.Name = "txtSchuss324";
            this.txtSchuss324.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss324.TabIndex = 0;
            this.txtSchuss324.Text = "1";
            this.txtSchuss324.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss334
            // 
            this.txtSchuss334.AutoSize = true;
            this.txtSchuss334.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss334.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss334.Location = new System.Drawing.Point(124, 33);
            this.txtSchuss334.Name = "txtSchuss334";
            this.txtSchuss334.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss334.TabIndex = 1;
            this.txtSchuss334.Text = "10";
            this.txtSchuss334.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss344
            // 
            this.txtSchuss344.AutoSize = true;
            this.txtSchuss344.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss344.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss344.Location = new System.Drawing.Point(164, 33);
            this.txtSchuss344.Name = "txtSchuss344";
            this.txtSchuss344.Size = new System.Drawing.Size(34, 7);
            this.txtSchuss344.TabIndex = 0;
            this.txtSchuss344.Text = "1";
            this.txtSchuss344.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss305
            // 
            this.txtSchuss305.AutoSize = true;
            this.txtSchuss305.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss305.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss305.Location = new System.Drawing.Point(4, 41);
            this.txtSchuss305.Name = "txtSchuss305";
            this.txtSchuss305.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss305.TabIndex = 0;
            this.txtSchuss305.Text = "1";
            this.txtSchuss305.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss315
            // 
            this.txtSchuss315.AutoSize = true;
            this.txtSchuss315.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss315.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss315.Location = new System.Drawing.Point(44, 41);
            this.txtSchuss315.Name = "txtSchuss315";
            this.txtSchuss315.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss315.TabIndex = 1;
            this.txtSchuss315.Text = "10";
            this.txtSchuss315.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss325
            // 
            this.txtSchuss325.AutoSize = true;
            this.txtSchuss325.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss325.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss325.Location = new System.Drawing.Point(84, 41);
            this.txtSchuss325.Name = "txtSchuss325";
            this.txtSchuss325.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss325.TabIndex = 0;
            this.txtSchuss325.Text = "1";
            this.txtSchuss325.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss335
            // 
            this.txtSchuss335.AutoSize = true;
            this.txtSchuss335.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss335.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss335.Location = new System.Drawing.Point(124, 41);
            this.txtSchuss335.Name = "txtSchuss335";
            this.txtSchuss335.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss335.TabIndex = 1;
            this.txtSchuss335.Text = "10";
            this.txtSchuss335.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss345
            // 
            this.txtSchuss345.AutoSize = true;
            this.txtSchuss345.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss345.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss345.Location = new System.Drawing.Point(164, 41);
            this.txtSchuss345.Name = "txtSchuss345";
            this.txtSchuss345.Size = new System.Drawing.Size(34, 7);
            this.txtSchuss345.TabIndex = 0;
            this.txtSchuss345.Text = "1";
            this.txtSchuss345.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss306
            // 
            this.txtSchuss306.AutoSize = true;
            this.txtSchuss306.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss306.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss306.Location = new System.Drawing.Point(4, 49);
            this.txtSchuss306.Name = "txtSchuss306";
            this.txtSchuss306.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss306.TabIndex = 0;
            this.txtSchuss306.Text = "1";
            this.txtSchuss306.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss316
            // 
            this.txtSchuss316.AutoSize = true;
            this.txtSchuss316.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss316.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss316.Location = new System.Drawing.Point(44, 49);
            this.txtSchuss316.Name = "txtSchuss316";
            this.txtSchuss316.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss316.TabIndex = 1;
            this.txtSchuss316.Text = "10";
            this.txtSchuss316.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss326
            // 
            this.txtSchuss326.AutoSize = true;
            this.txtSchuss326.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss326.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss326.Location = new System.Drawing.Point(84, 49);
            this.txtSchuss326.Name = "txtSchuss326";
            this.txtSchuss326.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss326.TabIndex = 0;
            this.txtSchuss326.Text = "1";
            this.txtSchuss326.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss336
            // 
            this.txtSchuss336.AutoSize = true;
            this.txtSchuss336.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss336.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss336.Location = new System.Drawing.Point(124, 49);
            this.txtSchuss336.Name = "txtSchuss336";
            this.txtSchuss336.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss336.TabIndex = 1;
            this.txtSchuss336.Text = "10";
            this.txtSchuss336.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss346
            // 
            this.txtSchuss346.AutoSize = true;
            this.txtSchuss346.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss346.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss346.Location = new System.Drawing.Point(164, 49);
            this.txtSchuss346.Name = "txtSchuss346";
            this.txtSchuss346.Size = new System.Drawing.Size(34, 7);
            this.txtSchuss346.TabIndex = 0;
            this.txtSchuss346.Text = "1";
            this.txtSchuss346.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss307
            // 
            this.txtSchuss307.AutoSize = true;
            this.txtSchuss307.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss307.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss307.Location = new System.Drawing.Point(4, 57);
            this.txtSchuss307.Name = "txtSchuss307";
            this.txtSchuss307.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss307.TabIndex = 0;
            this.txtSchuss307.Text = "1";
            this.txtSchuss307.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss317
            // 
            this.txtSchuss317.AutoSize = true;
            this.txtSchuss317.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss317.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss317.Location = new System.Drawing.Point(44, 57);
            this.txtSchuss317.Name = "txtSchuss317";
            this.txtSchuss317.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss317.TabIndex = 1;
            this.txtSchuss317.Text = "10";
            this.txtSchuss317.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss327
            // 
            this.txtSchuss327.AutoSize = true;
            this.txtSchuss327.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss327.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss327.Location = new System.Drawing.Point(84, 57);
            this.txtSchuss327.Name = "txtSchuss327";
            this.txtSchuss327.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss327.TabIndex = 0;
            this.txtSchuss327.Text = "1";
            this.txtSchuss327.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss337
            // 
            this.txtSchuss337.AutoSize = true;
            this.txtSchuss337.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss337.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss337.Location = new System.Drawing.Point(124, 57);
            this.txtSchuss337.Name = "txtSchuss337";
            this.txtSchuss337.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss337.TabIndex = 1;
            this.txtSchuss337.Text = "10";
            this.txtSchuss337.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss347
            // 
            this.txtSchuss347.AutoSize = true;
            this.txtSchuss347.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss347.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss347.Location = new System.Drawing.Point(164, 57);
            this.txtSchuss347.Name = "txtSchuss347";
            this.txtSchuss347.Size = new System.Drawing.Size(34, 12);
            this.txtSchuss347.TabIndex = 0;
            this.txtSchuss347.Text = "1";
            this.txtSchuss347.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Stand6SplitContainer
            // 
            this.Stand6SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stand6SplitContainer.Location = new System.Drawing.Point(638, 214);
            this.Stand6SplitContainer.Name = "Stand6SplitContainer";
            // 
            // Stand6SplitContainer.Panel1
            // 
            this.Stand6SplitContainer.Panel1.Controls.Add(this.stand6Zielscheibe);
            // 
            // Stand6SplitContainer.Panel2
            // 
            this.Stand6SplitContainer.Panel2.Controls.Add(this.lblProbe6);
            this.Stand6SplitContainer.Panel2.Controls.Add(this.txtSchussStand6);
            this.Stand6SplitContainer.Panel2.Controls.Add(this.lblSchussStand6);
            this.Stand6SplitContainer.Panel2.Controls.Add(this.txtDisziplinStand6);
            this.Stand6SplitContainer.Panel2.Controls.Add(this.lblDisziplinStand6);
            this.Stand6SplitContainer.Panel2.Controls.Add(this.txtSchuetzeStand6);
            this.Stand6SplitContainer.Panel2.Controls.Add(this.lblSchuetzeStand6);
            this.Stand6SplitContainer.Panel2.Controls.Add(this.Stand6SchussPanel);
            this.Stand6SplitContainer.Size = new System.Drawing.Size(308, 199);
            this.Stand6SplitContainer.SplitterDistance = 102;
            this.Stand6SplitContainer.TabIndex = 2;
            // 
            // stand6Zielscheibe
            // 
            this.stand6Zielscheibe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stand6Zielscheibe.Location = new System.Drawing.Point(0, 0);
            this.stand6Zielscheibe.Name = "stand6Zielscheibe";
            this.stand6Zielscheibe.Size = new System.Drawing.Size(102, 199);
            this.stand6Zielscheibe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stand6Zielscheibe.TabIndex = 1;
            this.stand6Zielscheibe.TabStop = false;
            this.stand6Zielscheibe.Paint += new System.Windows.Forms.PaintEventHandler(this.stand6Zielscheibe_Paint);
            this.stand6Zielscheibe.DoubleClick += new System.EventHandler(this.stand6Zielscheibe_DoubleClick);
            // 
            // lblProbe6
            // 
            this.lblProbe6.AutoSize = true;
            this.lblProbe6.Location = new System.Drawing.Point(-3, 113);
            this.lblProbe6.Name = "lblProbe6";
            this.lblProbe6.Size = new System.Drawing.Size(41, 13);
            this.lblProbe6.TabIndex = 34;
            this.lblProbe6.Text = "label15";
            // 
            // txtSchussStand6
            // 
            this.txtSchussStand6.AutoSize = true;
            this.txtSchussStand6.Location = new System.Drawing.Point(-3, 81);
            this.txtSchussStand6.Name = "txtSchussStand6";
            this.txtSchussStand6.Size = new System.Drawing.Size(0, 13);
            this.txtSchussStand6.TabIndex = 32;
            // 
            // lblSchussStand6
            // 
            this.lblSchussStand6.AutoSize = true;
            this.lblSchussStand6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchussStand6.Location = new System.Drawing.Point(-3, 68);
            this.lblSchussStand6.Name = "lblSchussStand6";
            this.lblSchussStand6.Size = new System.Drawing.Size(51, 13);
            this.lblSchussStand6.TabIndex = 32;
            this.lblSchussStand6.Text = "Summe:";
            // 
            // txtDisziplinStand6
            // 
            this.txtDisziplinStand6.AutoSize = true;
            this.txtDisziplinStand6.Location = new System.Drawing.Point(-3, 39);
            this.txtDisziplinStand6.Name = "txtDisziplinStand6";
            this.txtDisziplinStand6.Size = new System.Drawing.Size(0, 13);
            this.txtDisziplinStand6.TabIndex = 32;
            // 
            // lblDisziplinStand6
            // 
            this.lblDisziplinStand6.AutoSize = true;
            this.lblDisziplinStand6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisziplinStand6.Location = new System.Drawing.Point(-3, 26);
            this.lblDisziplinStand6.Name = "lblDisziplinStand6";
            this.lblDisziplinStand6.Size = new System.Drawing.Size(54, 13);
            this.lblDisziplinStand6.TabIndex = 32;
            this.lblDisziplinStand6.Text = "Disziplin";
            // 
            // txtSchuetzeStand6
            // 
            this.txtSchuetzeStand6.AutoSize = true;
            this.txtSchuetzeStand6.Location = new System.Drawing.Point(-3, 13);
            this.txtSchuetzeStand6.Name = "txtSchuetzeStand6";
            this.txtSchuetzeStand6.Size = new System.Drawing.Size(0, 13);
            this.txtSchuetzeStand6.TabIndex = 32;
            // 
            // lblSchuetzeStand6
            // 
            this.lblSchuetzeStand6.AutoSize = true;
            this.lblSchuetzeStand6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchuetzeStand6.Location = new System.Drawing.Point(-3, 0);
            this.lblSchuetzeStand6.Name = "lblSchuetzeStand6";
            this.lblSchuetzeStand6.Size = new System.Drawing.Size(53, 13);
            this.lblSchuetzeStand6.TabIndex = 32;
            this.lblSchuetzeStand6.Text = "Schütze";
            // 
            // Stand6SchussPanel
            // 
            this.Stand6SchussPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Stand6SchussPanel.ColumnCount = 5;
            this.Stand6SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand6SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand6SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand6SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand6SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss600, 0, 0);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss610, 1, 0);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss620, 2, 0);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss630, 3, 0);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss640, 4, 0);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss601, 0, 1);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss611, 1, 1);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss621, 2, 1);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss631, 3, 1);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss641, 4, 1);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss602, 0, 2);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss612, 1, 2);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss622, 2, 2);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss632, 3, 2);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss642, 4, 2);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss603, 0, 3);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss613, 1, 3);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss623, 2, 3);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss633, 3, 3);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss643, 4, 3);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss604, 0, 4);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss614, 1, 4);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss624, 2, 4);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss634, 3, 4);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss644, 4, 4);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss605, 0, 5);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss615, 1, 5);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss625, 2, 5);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss635, 3, 5);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss645, 4, 5);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss606, 0, 6);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss616, 1, 6);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss626, 2, 6);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss636, 3, 6);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss646, 4, 6);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss607, 0, 7);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss617, 1, 7);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss627, 2, 7);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss637, 3, 7);
            this.Stand6SchussPanel.Controls.Add(this.txtSchuss647, 4, 7);
            this.Stand6SchussPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Stand6SchussPanel.Location = new System.Drawing.Point(0, 129);
            this.Stand6SchussPanel.Name = "Stand6SchussPanel";
            this.Stand6SchussPanel.RowCount = 8;
            this.Stand6SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand6SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand6SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand6SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand6SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand6SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand6SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand6SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand6SchussPanel.Size = new System.Drawing.Size(202, 70);
            this.Stand6SchussPanel.TabIndex = 6;
            // 
            // txtSchuss600
            // 
            this.txtSchuss600.AutoSize = true;
            this.txtSchuss600.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss600.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss600.Location = new System.Drawing.Point(4, 1);
            this.txtSchuss600.Name = "txtSchuss600";
            this.txtSchuss600.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss600.TabIndex = 0;
            this.txtSchuss600.Text = "1";
            this.txtSchuss600.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss610
            // 
            this.txtSchuss610.AutoSize = true;
            this.txtSchuss610.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss610.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss610.Location = new System.Drawing.Point(44, 1);
            this.txtSchuss610.Name = "txtSchuss610";
            this.txtSchuss610.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss610.TabIndex = 1;
            this.txtSchuss610.Text = "10";
            this.txtSchuss610.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss620
            // 
            this.txtSchuss620.AutoSize = true;
            this.txtSchuss620.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss620.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss620.Location = new System.Drawing.Point(84, 1);
            this.txtSchuss620.Name = "txtSchuss620";
            this.txtSchuss620.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss620.TabIndex = 0;
            this.txtSchuss620.Text = "1";
            this.txtSchuss620.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss630
            // 
            this.txtSchuss630.AutoSize = true;
            this.txtSchuss630.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss630.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss630.Location = new System.Drawing.Point(124, 1);
            this.txtSchuss630.Name = "txtSchuss630";
            this.txtSchuss630.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss630.TabIndex = 1;
            this.txtSchuss630.Text = "10";
            this.txtSchuss630.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss640
            // 
            this.txtSchuss640.AutoSize = true;
            this.txtSchuss640.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss640.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss640.Location = new System.Drawing.Point(164, 1);
            this.txtSchuss640.Name = "txtSchuss640";
            this.txtSchuss640.Size = new System.Drawing.Size(34, 7);
            this.txtSchuss640.TabIndex = 0;
            this.txtSchuss640.Text = "1";
            this.txtSchuss640.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss601
            // 
            this.txtSchuss601.AutoSize = true;
            this.txtSchuss601.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss601.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss601.Location = new System.Drawing.Point(4, 9);
            this.txtSchuss601.Name = "txtSchuss601";
            this.txtSchuss601.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss601.TabIndex = 0;
            this.txtSchuss601.Text = "1";
            this.txtSchuss601.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss611
            // 
            this.txtSchuss611.AutoSize = true;
            this.txtSchuss611.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss611.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss611.Location = new System.Drawing.Point(44, 9);
            this.txtSchuss611.Name = "txtSchuss611";
            this.txtSchuss611.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss611.TabIndex = 1;
            this.txtSchuss611.Text = "10";
            this.txtSchuss611.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss621
            // 
            this.txtSchuss621.AutoSize = true;
            this.txtSchuss621.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss621.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss621.Location = new System.Drawing.Point(84, 9);
            this.txtSchuss621.Name = "txtSchuss621";
            this.txtSchuss621.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss621.TabIndex = 0;
            this.txtSchuss621.Text = "1";
            this.txtSchuss621.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss631
            // 
            this.txtSchuss631.AutoSize = true;
            this.txtSchuss631.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss631.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss631.Location = new System.Drawing.Point(124, 9);
            this.txtSchuss631.Name = "txtSchuss631";
            this.txtSchuss631.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss631.TabIndex = 1;
            this.txtSchuss631.Text = "10";
            this.txtSchuss631.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss641
            // 
            this.txtSchuss641.AutoSize = true;
            this.txtSchuss641.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss641.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss641.Location = new System.Drawing.Point(164, 9);
            this.txtSchuss641.Name = "txtSchuss641";
            this.txtSchuss641.Size = new System.Drawing.Size(34, 7);
            this.txtSchuss641.TabIndex = 0;
            this.txtSchuss641.Text = "1";
            this.txtSchuss641.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss602
            // 
            this.txtSchuss602.AutoSize = true;
            this.txtSchuss602.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss602.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss602.Location = new System.Drawing.Point(4, 17);
            this.txtSchuss602.Name = "txtSchuss602";
            this.txtSchuss602.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss602.TabIndex = 0;
            this.txtSchuss602.Text = "1";
            this.txtSchuss602.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss612
            // 
            this.txtSchuss612.AutoSize = true;
            this.txtSchuss612.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss612.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss612.Location = new System.Drawing.Point(44, 17);
            this.txtSchuss612.Name = "txtSchuss612";
            this.txtSchuss612.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss612.TabIndex = 1;
            this.txtSchuss612.Text = "10";
            this.txtSchuss612.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss622
            // 
            this.txtSchuss622.AutoSize = true;
            this.txtSchuss622.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss622.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss622.Location = new System.Drawing.Point(84, 17);
            this.txtSchuss622.Name = "txtSchuss622";
            this.txtSchuss622.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss622.TabIndex = 0;
            this.txtSchuss622.Text = "1";
            this.txtSchuss622.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss632
            // 
            this.txtSchuss632.AutoSize = true;
            this.txtSchuss632.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss632.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss632.Location = new System.Drawing.Point(124, 17);
            this.txtSchuss632.Name = "txtSchuss632";
            this.txtSchuss632.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss632.TabIndex = 1;
            this.txtSchuss632.Text = "10";
            this.txtSchuss632.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss642
            // 
            this.txtSchuss642.AutoSize = true;
            this.txtSchuss642.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss642.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss642.Location = new System.Drawing.Point(164, 17);
            this.txtSchuss642.Name = "txtSchuss642";
            this.txtSchuss642.Size = new System.Drawing.Size(34, 7);
            this.txtSchuss642.TabIndex = 0;
            this.txtSchuss642.Text = "1";
            this.txtSchuss642.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss603
            // 
            this.txtSchuss603.AutoSize = true;
            this.txtSchuss603.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss603.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss603.Location = new System.Drawing.Point(4, 25);
            this.txtSchuss603.Name = "txtSchuss603";
            this.txtSchuss603.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss603.TabIndex = 0;
            this.txtSchuss603.Text = "1";
            this.txtSchuss603.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss613
            // 
            this.txtSchuss613.AutoSize = true;
            this.txtSchuss613.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss613.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss613.Location = new System.Drawing.Point(44, 25);
            this.txtSchuss613.Name = "txtSchuss613";
            this.txtSchuss613.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss613.TabIndex = 1;
            this.txtSchuss613.Text = "10";
            this.txtSchuss613.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss623
            // 
            this.txtSchuss623.AutoSize = true;
            this.txtSchuss623.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss623.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss623.Location = new System.Drawing.Point(84, 25);
            this.txtSchuss623.Name = "txtSchuss623";
            this.txtSchuss623.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss623.TabIndex = 0;
            this.txtSchuss623.Text = "1";
            this.txtSchuss623.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss633
            // 
            this.txtSchuss633.AutoSize = true;
            this.txtSchuss633.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss633.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss633.Location = new System.Drawing.Point(124, 25);
            this.txtSchuss633.Name = "txtSchuss633";
            this.txtSchuss633.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss633.TabIndex = 1;
            this.txtSchuss633.Text = "10";
            this.txtSchuss633.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss643
            // 
            this.txtSchuss643.AutoSize = true;
            this.txtSchuss643.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss643.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss643.Location = new System.Drawing.Point(164, 25);
            this.txtSchuss643.Name = "txtSchuss643";
            this.txtSchuss643.Size = new System.Drawing.Size(34, 7);
            this.txtSchuss643.TabIndex = 0;
            this.txtSchuss643.Text = "1";
            this.txtSchuss643.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss604
            // 
            this.txtSchuss604.AutoSize = true;
            this.txtSchuss604.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss604.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss604.Location = new System.Drawing.Point(4, 33);
            this.txtSchuss604.Name = "txtSchuss604";
            this.txtSchuss604.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss604.TabIndex = 0;
            this.txtSchuss604.Text = "1";
            this.txtSchuss604.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss614
            // 
            this.txtSchuss614.AutoSize = true;
            this.txtSchuss614.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss614.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss614.Location = new System.Drawing.Point(44, 33);
            this.txtSchuss614.Name = "txtSchuss614";
            this.txtSchuss614.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss614.TabIndex = 1;
            this.txtSchuss614.Text = "10";
            this.txtSchuss614.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss624
            // 
            this.txtSchuss624.AutoSize = true;
            this.txtSchuss624.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss624.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss624.Location = new System.Drawing.Point(84, 33);
            this.txtSchuss624.Name = "txtSchuss624";
            this.txtSchuss624.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss624.TabIndex = 0;
            this.txtSchuss624.Text = "1";
            this.txtSchuss624.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss634
            // 
            this.txtSchuss634.AutoSize = true;
            this.txtSchuss634.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss634.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss634.Location = new System.Drawing.Point(124, 33);
            this.txtSchuss634.Name = "txtSchuss634";
            this.txtSchuss634.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss634.TabIndex = 1;
            this.txtSchuss634.Text = "10";
            this.txtSchuss634.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss644
            // 
            this.txtSchuss644.AutoSize = true;
            this.txtSchuss644.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss644.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss644.Location = new System.Drawing.Point(164, 33);
            this.txtSchuss644.Name = "txtSchuss644";
            this.txtSchuss644.Size = new System.Drawing.Size(34, 7);
            this.txtSchuss644.TabIndex = 0;
            this.txtSchuss644.Text = "1";
            this.txtSchuss644.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss605
            // 
            this.txtSchuss605.AutoSize = true;
            this.txtSchuss605.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss605.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss605.Location = new System.Drawing.Point(4, 41);
            this.txtSchuss605.Name = "txtSchuss605";
            this.txtSchuss605.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss605.TabIndex = 0;
            this.txtSchuss605.Text = "1";
            this.txtSchuss605.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss615
            // 
            this.txtSchuss615.AutoSize = true;
            this.txtSchuss615.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss615.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss615.Location = new System.Drawing.Point(44, 41);
            this.txtSchuss615.Name = "txtSchuss615";
            this.txtSchuss615.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss615.TabIndex = 1;
            this.txtSchuss615.Text = "10";
            this.txtSchuss615.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss625
            // 
            this.txtSchuss625.AutoSize = true;
            this.txtSchuss625.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss625.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss625.Location = new System.Drawing.Point(84, 41);
            this.txtSchuss625.Name = "txtSchuss625";
            this.txtSchuss625.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss625.TabIndex = 0;
            this.txtSchuss625.Text = "1";
            this.txtSchuss625.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss635
            // 
            this.txtSchuss635.AutoSize = true;
            this.txtSchuss635.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss635.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss635.Location = new System.Drawing.Point(124, 41);
            this.txtSchuss635.Name = "txtSchuss635";
            this.txtSchuss635.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss635.TabIndex = 1;
            this.txtSchuss635.Text = "10";
            this.txtSchuss635.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss645
            // 
            this.txtSchuss645.AutoSize = true;
            this.txtSchuss645.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss645.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss645.Location = new System.Drawing.Point(164, 41);
            this.txtSchuss645.Name = "txtSchuss645";
            this.txtSchuss645.Size = new System.Drawing.Size(34, 7);
            this.txtSchuss645.TabIndex = 0;
            this.txtSchuss645.Text = "1";
            this.txtSchuss645.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss606
            // 
            this.txtSchuss606.AutoSize = true;
            this.txtSchuss606.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss606.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss606.Location = new System.Drawing.Point(4, 49);
            this.txtSchuss606.Name = "txtSchuss606";
            this.txtSchuss606.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss606.TabIndex = 0;
            this.txtSchuss606.Text = "1";
            this.txtSchuss606.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss616
            // 
            this.txtSchuss616.AutoSize = true;
            this.txtSchuss616.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss616.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss616.Location = new System.Drawing.Point(44, 49);
            this.txtSchuss616.Name = "txtSchuss616";
            this.txtSchuss616.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss616.TabIndex = 1;
            this.txtSchuss616.Text = "10";
            this.txtSchuss616.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss626
            // 
            this.txtSchuss626.AutoSize = true;
            this.txtSchuss626.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss626.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss626.Location = new System.Drawing.Point(84, 49);
            this.txtSchuss626.Name = "txtSchuss626";
            this.txtSchuss626.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss626.TabIndex = 0;
            this.txtSchuss626.Text = "1";
            this.txtSchuss626.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss636
            // 
            this.txtSchuss636.AutoSize = true;
            this.txtSchuss636.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss636.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss636.Location = new System.Drawing.Point(124, 49);
            this.txtSchuss636.Name = "txtSchuss636";
            this.txtSchuss636.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss636.TabIndex = 1;
            this.txtSchuss636.Text = "10";
            this.txtSchuss636.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss646
            // 
            this.txtSchuss646.AutoSize = true;
            this.txtSchuss646.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss646.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss646.Location = new System.Drawing.Point(164, 49);
            this.txtSchuss646.Name = "txtSchuss646";
            this.txtSchuss646.Size = new System.Drawing.Size(34, 7);
            this.txtSchuss646.TabIndex = 0;
            this.txtSchuss646.Text = "1";
            this.txtSchuss646.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss607
            // 
            this.txtSchuss607.AutoSize = true;
            this.txtSchuss607.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss607.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss607.Location = new System.Drawing.Point(4, 57);
            this.txtSchuss607.Name = "txtSchuss607";
            this.txtSchuss607.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss607.TabIndex = 0;
            this.txtSchuss607.Text = "1";
            this.txtSchuss607.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss617
            // 
            this.txtSchuss617.AutoSize = true;
            this.txtSchuss617.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss617.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss617.Location = new System.Drawing.Point(44, 57);
            this.txtSchuss617.Name = "txtSchuss617";
            this.txtSchuss617.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss617.TabIndex = 1;
            this.txtSchuss617.Text = "10";
            this.txtSchuss617.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss627
            // 
            this.txtSchuss627.AutoSize = true;
            this.txtSchuss627.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss627.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss627.Location = new System.Drawing.Point(84, 57);
            this.txtSchuss627.Name = "txtSchuss627";
            this.txtSchuss627.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss627.TabIndex = 0;
            this.txtSchuss627.Text = "1";
            this.txtSchuss627.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss637
            // 
            this.txtSchuss637.AutoSize = true;
            this.txtSchuss637.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss637.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss637.Location = new System.Drawing.Point(124, 57);
            this.txtSchuss637.Name = "txtSchuss637";
            this.txtSchuss637.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss637.TabIndex = 1;
            this.txtSchuss637.Text = "10";
            this.txtSchuss637.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss647
            // 
            this.txtSchuss647.AutoSize = true;
            this.txtSchuss647.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss647.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss647.Location = new System.Drawing.Point(164, 57);
            this.txtSchuss647.Name = "txtSchuss647";
            this.txtSchuss647.Size = new System.Drawing.Size(34, 12);
            this.txtSchuss647.TabIndex = 0;
            this.txtSchuss647.Text = "1";
            this.txtSchuss647.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Stand5SplitContainer
            // 
            this.Stand5SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stand5SplitContainer.Location = new System.Drawing.Point(322, 214);
            this.Stand5SplitContainer.Name = "Stand5SplitContainer";
            // 
            // Stand5SplitContainer.Panel1
            // 
            this.Stand5SplitContainer.Panel1.Controls.Add(this.stand5Zielscheibe);
            // 
            // Stand5SplitContainer.Panel2
            // 
            this.Stand5SplitContainer.Panel2.Controls.Add(this.lblProbe5);
            this.Stand5SplitContainer.Panel2.Controls.Add(this.txtSchussStand5);
            this.Stand5SplitContainer.Panel2.Controls.Add(this.lblSchussStand5);
            this.Stand5SplitContainer.Panel2.Controls.Add(this.txtDisziplinStand5);
            this.Stand5SplitContainer.Panel2.Controls.Add(this.lblDisziplinStand5);
            this.Stand5SplitContainer.Panel2.Controls.Add(this.txtSchuetzeStand5);
            this.Stand5SplitContainer.Panel2.Controls.Add(this.lblSchuetzeStand5);
            this.Stand5SplitContainer.Panel2.Controls.Add(this.Stand5SchussPanel);
            this.Stand5SplitContainer.Size = new System.Drawing.Size(307, 199);
            this.Stand5SplitContainer.SplitterDistance = 102;
            this.Stand5SplitContainer.TabIndex = 2;
            // 
            // stand5Zielscheibe
            // 
            this.stand5Zielscheibe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stand5Zielscheibe.Location = new System.Drawing.Point(0, 0);
            this.stand5Zielscheibe.Name = "stand5Zielscheibe";
            this.stand5Zielscheibe.Size = new System.Drawing.Size(102, 199);
            this.stand5Zielscheibe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stand5Zielscheibe.TabIndex = 1;
            this.stand5Zielscheibe.TabStop = false;
            this.stand5Zielscheibe.Paint += new System.Windows.Forms.PaintEventHandler(this.stand5Zielscheibe_Paint);
            this.stand5Zielscheibe.DoubleClick += new System.EventHandler(this.stand5Zielscheibe_DoubleClick);
            // 
            // lblProbe5
            // 
            this.lblProbe5.AutoSize = true;
            this.lblProbe5.Location = new System.Drawing.Point(-3, 113);
            this.lblProbe5.Name = "lblProbe5";
            this.lblProbe5.Size = new System.Drawing.Size(41, 13);
            this.lblProbe5.TabIndex = 35;
            this.lblProbe5.Text = "label16";
            // 
            // txtSchussStand5
            // 
            this.txtSchussStand5.AutoSize = true;
            this.txtSchussStand5.Location = new System.Drawing.Point(-3, 81);
            this.txtSchussStand5.Name = "txtSchussStand5";
            this.txtSchussStand5.Size = new System.Drawing.Size(0, 13);
            this.txtSchussStand5.TabIndex = 32;
            // 
            // lblSchussStand5
            // 
            this.lblSchussStand5.AutoSize = true;
            this.lblSchussStand5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchussStand5.Location = new System.Drawing.Point(-3, 68);
            this.lblSchussStand5.Name = "lblSchussStand5";
            this.lblSchussStand5.Size = new System.Drawing.Size(51, 13);
            this.lblSchussStand5.TabIndex = 32;
            this.lblSchussStand5.Text = "Summe:";
            // 
            // txtDisziplinStand5
            // 
            this.txtDisziplinStand5.AutoSize = true;
            this.txtDisziplinStand5.Location = new System.Drawing.Point(-3, 39);
            this.txtDisziplinStand5.Name = "txtDisziplinStand5";
            this.txtDisziplinStand5.Size = new System.Drawing.Size(0, 13);
            this.txtDisziplinStand5.TabIndex = 32;
            // 
            // lblDisziplinStand5
            // 
            this.lblDisziplinStand5.AutoSize = true;
            this.lblDisziplinStand5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisziplinStand5.Location = new System.Drawing.Point(-3, 26);
            this.lblDisziplinStand5.Name = "lblDisziplinStand5";
            this.lblDisziplinStand5.Size = new System.Drawing.Size(54, 13);
            this.lblDisziplinStand5.TabIndex = 32;
            this.lblDisziplinStand5.Text = "Disziplin";
            // 
            // txtSchuetzeStand5
            // 
            this.txtSchuetzeStand5.AutoSize = true;
            this.txtSchuetzeStand5.Location = new System.Drawing.Point(-3, 13);
            this.txtSchuetzeStand5.Name = "txtSchuetzeStand5";
            this.txtSchuetzeStand5.Size = new System.Drawing.Size(0, 13);
            this.txtSchuetzeStand5.TabIndex = 32;
            // 
            // lblSchuetzeStand5
            // 
            this.lblSchuetzeStand5.AutoSize = true;
            this.lblSchuetzeStand5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchuetzeStand5.Location = new System.Drawing.Point(-3, 0);
            this.lblSchuetzeStand5.Name = "lblSchuetzeStand5";
            this.lblSchuetzeStand5.Size = new System.Drawing.Size(53, 13);
            this.lblSchuetzeStand5.TabIndex = 32;
            this.lblSchuetzeStand5.Text = "Schütze";
            // 
            // Stand5SchussPanel
            // 
            this.Stand5SchussPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Stand5SchussPanel.ColumnCount = 5;
            this.Stand5SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand5SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand5SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand5SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand5SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss500, 0, 0);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss510, 1, 0);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss520, 2, 0);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss530, 3, 0);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss540, 4, 0);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss501, 0, 1);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss511, 1, 1);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss521, 2, 1);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss531, 3, 1);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss541, 4, 1);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss502, 0, 2);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss512, 1, 2);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss522, 2, 2);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss532, 3, 2);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss542, 4, 2);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss503, 0, 3);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss513, 1, 3);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss523, 2, 3);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss533, 3, 3);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss543, 4, 3);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss504, 0, 4);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss514, 1, 4);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss524, 2, 4);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss534, 3, 4);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss544, 4, 4);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss505, 0, 5);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss515, 1, 5);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss525, 2, 5);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss535, 3, 5);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss545, 4, 5);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss506, 0, 6);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss516, 1, 6);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss526, 2, 6);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss536, 3, 6);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss546, 4, 6);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss507, 0, 7);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss517, 1, 7);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss527, 2, 7);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss537, 3, 7);
            this.Stand5SchussPanel.Controls.Add(this.txtSchuss547, 4, 7);
            this.Stand5SchussPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Stand5SchussPanel.Location = new System.Drawing.Point(0, 129);
            this.Stand5SchussPanel.Name = "Stand5SchussPanel";
            this.Stand5SchussPanel.RowCount = 8;
            this.Stand5SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand5SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand5SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand5SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand5SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand5SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand5SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand5SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand5SchussPanel.Size = new System.Drawing.Size(201, 70);
            this.Stand5SchussPanel.TabIndex = 6;
            // 
            // txtSchuss500
            // 
            this.txtSchuss500.AutoSize = true;
            this.txtSchuss500.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss500.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss500.Location = new System.Drawing.Point(4, 1);
            this.txtSchuss500.Name = "txtSchuss500";
            this.txtSchuss500.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss500.TabIndex = 0;
            this.txtSchuss500.Text = "1";
            this.txtSchuss500.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss510
            // 
            this.txtSchuss510.AutoSize = true;
            this.txtSchuss510.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss510.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss510.Location = new System.Drawing.Point(44, 1);
            this.txtSchuss510.Name = "txtSchuss510";
            this.txtSchuss510.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss510.TabIndex = 1;
            this.txtSchuss510.Text = "10";
            this.txtSchuss510.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss520
            // 
            this.txtSchuss520.AutoSize = true;
            this.txtSchuss520.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss520.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss520.Location = new System.Drawing.Point(84, 1);
            this.txtSchuss520.Name = "txtSchuss520";
            this.txtSchuss520.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss520.TabIndex = 0;
            this.txtSchuss520.Text = "1";
            this.txtSchuss520.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss530
            // 
            this.txtSchuss530.AutoSize = true;
            this.txtSchuss530.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss530.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss530.Location = new System.Drawing.Point(124, 1);
            this.txtSchuss530.Name = "txtSchuss530";
            this.txtSchuss530.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss530.TabIndex = 1;
            this.txtSchuss530.Text = "10";
            this.txtSchuss530.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss540
            // 
            this.txtSchuss540.AutoSize = true;
            this.txtSchuss540.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss540.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss540.Location = new System.Drawing.Point(164, 1);
            this.txtSchuss540.Name = "txtSchuss540";
            this.txtSchuss540.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss540.TabIndex = 0;
            this.txtSchuss540.Text = "1";
            this.txtSchuss540.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss501
            // 
            this.txtSchuss501.AutoSize = true;
            this.txtSchuss501.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss501.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss501.Location = new System.Drawing.Point(4, 9);
            this.txtSchuss501.Name = "txtSchuss501";
            this.txtSchuss501.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss501.TabIndex = 0;
            this.txtSchuss501.Text = "1";
            this.txtSchuss501.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss511
            // 
            this.txtSchuss511.AutoSize = true;
            this.txtSchuss511.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss511.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss511.Location = new System.Drawing.Point(44, 9);
            this.txtSchuss511.Name = "txtSchuss511";
            this.txtSchuss511.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss511.TabIndex = 1;
            this.txtSchuss511.Text = "10";
            this.txtSchuss511.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss521
            // 
            this.txtSchuss521.AutoSize = true;
            this.txtSchuss521.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss521.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss521.Location = new System.Drawing.Point(84, 9);
            this.txtSchuss521.Name = "txtSchuss521";
            this.txtSchuss521.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss521.TabIndex = 0;
            this.txtSchuss521.Text = "1";
            this.txtSchuss521.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss531
            // 
            this.txtSchuss531.AutoSize = true;
            this.txtSchuss531.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss531.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss531.Location = new System.Drawing.Point(124, 9);
            this.txtSchuss531.Name = "txtSchuss531";
            this.txtSchuss531.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss531.TabIndex = 1;
            this.txtSchuss531.Text = "10";
            this.txtSchuss531.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss541
            // 
            this.txtSchuss541.AutoSize = true;
            this.txtSchuss541.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss541.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss541.Location = new System.Drawing.Point(164, 9);
            this.txtSchuss541.Name = "txtSchuss541";
            this.txtSchuss541.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss541.TabIndex = 0;
            this.txtSchuss541.Text = "1";
            this.txtSchuss541.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss502
            // 
            this.txtSchuss502.AutoSize = true;
            this.txtSchuss502.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss502.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss502.Location = new System.Drawing.Point(4, 17);
            this.txtSchuss502.Name = "txtSchuss502";
            this.txtSchuss502.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss502.TabIndex = 0;
            this.txtSchuss502.Text = "1";
            this.txtSchuss502.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss512
            // 
            this.txtSchuss512.AutoSize = true;
            this.txtSchuss512.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss512.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss512.Location = new System.Drawing.Point(44, 17);
            this.txtSchuss512.Name = "txtSchuss512";
            this.txtSchuss512.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss512.TabIndex = 1;
            this.txtSchuss512.Text = "10";
            this.txtSchuss512.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss522
            // 
            this.txtSchuss522.AutoSize = true;
            this.txtSchuss522.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss522.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss522.Location = new System.Drawing.Point(84, 17);
            this.txtSchuss522.Name = "txtSchuss522";
            this.txtSchuss522.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss522.TabIndex = 0;
            this.txtSchuss522.Text = "1";
            this.txtSchuss522.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss532
            // 
            this.txtSchuss532.AutoSize = true;
            this.txtSchuss532.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss532.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss532.Location = new System.Drawing.Point(124, 17);
            this.txtSchuss532.Name = "txtSchuss532";
            this.txtSchuss532.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss532.TabIndex = 1;
            this.txtSchuss532.Text = "10";
            this.txtSchuss532.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss542
            // 
            this.txtSchuss542.AutoSize = true;
            this.txtSchuss542.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss542.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss542.Location = new System.Drawing.Point(164, 17);
            this.txtSchuss542.Name = "txtSchuss542";
            this.txtSchuss542.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss542.TabIndex = 0;
            this.txtSchuss542.Text = "1";
            this.txtSchuss542.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss503
            // 
            this.txtSchuss503.AutoSize = true;
            this.txtSchuss503.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss503.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss503.Location = new System.Drawing.Point(4, 25);
            this.txtSchuss503.Name = "txtSchuss503";
            this.txtSchuss503.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss503.TabIndex = 0;
            this.txtSchuss503.Text = "1";
            this.txtSchuss503.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss513
            // 
            this.txtSchuss513.AutoSize = true;
            this.txtSchuss513.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss513.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss513.Location = new System.Drawing.Point(44, 25);
            this.txtSchuss513.Name = "txtSchuss513";
            this.txtSchuss513.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss513.TabIndex = 1;
            this.txtSchuss513.Text = "10";
            this.txtSchuss513.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss523
            // 
            this.txtSchuss523.AutoSize = true;
            this.txtSchuss523.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss523.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss523.Location = new System.Drawing.Point(84, 25);
            this.txtSchuss523.Name = "txtSchuss523";
            this.txtSchuss523.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss523.TabIndex = 0;
            this.txtSchuss523.Text = "1";
            this.txtSchuss523.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss533
            // 
            this.txtSchuss533.AutoSize = true;
            this.txtSchuss533.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss533.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss533.Location = new System.Drawing.Point(124, 25);
            this.txtSchuss533.Name = "txtSchuss533";
            this.txtSchuss533.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss533.TabIndex = 1;
            this.txtSchuss533.Text = "10";
            this.txtSchuss533.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss543
            // 
            this.txtSchuss543.AutoSize = true;
            this.txtSchuss543.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss543.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss543.Location = new System.Drawing.Point(164, 25);
            this.txtSchuss543.Name = "txtSchuss543";
            this.txtSchuss543.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss543.TabIndex = 0;
            this.txtSchuss543.Text = "1";
            this.txtSchuss543.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss504
            // 
            this.txtSchuss504.AutoSize = true;
            this.txtSchuss504.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss504.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss504.Location = new System.Drawing.Point(4, 33);
            this.txtSchuss504.Name = "txtSchuss504";
            this.txtSchuss504.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss504.TabIndex = 0;
            this.txtSchuss504.Text = "1";
            this.txtSchuss504.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss514
            // 
            this.txtSchuss514.AutoSize = true;
            this.txtSchuss514.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss514.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss514.Location = new System.Drawing.Point(44, 33);
            this.txtSchuss514.Name = "txtSchuss514";
            this.txtSchuss514.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss514.TabIndex = 1;
            this.txtSchuss514.Text = "10";
            this.txtSchuss514.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss524
            // 
            this.txtSchuss524.AutoSize = true;
            this.txtSchuss524.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss524.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss524.Location = new System.Drawing.Point(84, 33);
            this.txtSchuss524.Name = "txtSchuss524";
            this.txtSchuss524.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss524.TabIndex = 0;
            this.txtSchuss524.Text = "1";
            this.txtSchuss524.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss534
            // 
            this.txtSchuss534.AutoSize = true;
            this.txtSchuss534.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss534.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss534.Location = new System.Drawing.Point(124, 33);
            this.txtSchuss534.Name = "txtSchuss534";
            this.txtSchuss534.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss534.TabIndex = 1;
            this.txtSchuss534.Text = "10";
            this.txtSchuss534.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss544
            // 
            this.txtSchuss544.AutoSize = true;
            this.txtSchuss544.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss544.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss544.Location = new System.Drawing.Point(164, 33);
            this.txtSchuss544.Name = "txtSchuss544";
            this.txtSchuss544.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss544.TabIndex = 0;
            this.txtSchuss544.Text = "1";
            this.txtSchuss544.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss505
            // 
            this.txtSchuss505.AutoSize = true;
            this.txtSchuss505.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss505.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss505.Location = new System.Drawing.Point(4, 41);
            this.txtSchuss505.Name = "txtSchuss505";
            this.txtSchuss505.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss505.TabIndex = 0;
            this.txtSchuss505.Text = "1";
            this.txtSchuss505.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss515
            // 
            this.txtSchuss515.AutoSize = true;
            this.txtSchuss515.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss515.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss515.Location = new System.Drawing.Point(44, 41);
            this.txtSchuss515.Name = "txtSchuss515";
            this.txtSchuss515.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss515.TabIndex = 1;
            this.txtSchuss515.Text = "10";
            this.txtSchuss515.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss525
            // 
            this.txtSchuss525.AutoSize = true;
            this.txtSchuss525.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss525.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss525.Location = new System.Drawing.Point(84, 41);
            this.txtSchuss525.Name = "txtSchuss525";
            this.txtSchuss525.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss525.TabIndex = 0;
            this.txtSchuss525.Text = "1";
            this.txtSchuss525.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss535
            // 
            this.txtSchuss535.AutoSize = true;
            this.txtSchuss535.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss535.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss535.Location = new System.Drawing.Point(124, 41);
            this.txtSchuss535.Name = "txtSchuss535";
            this.txtSchuss535.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss535.TabIndex = 1;
            this.txtSchuss535.Text = "10";
            this.txtSchuss535.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss545
            // 
            this.txtSchuss545.AutoSize = true;
            this.txtSchuss545.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss545.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss545.Location = new System.Drawing.Point(164, 41);
            this.txtSchuss545.Name = "txtSchuss545";
            this.txtSchuss545.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss545.TabIndex = 0;
            this.txtSchuss545.Text = "1";
            this.txtSchuss545.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss506
            // 
            this.txtSchuss506.AutoSize = true;
            this.txtSchuss506.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss506.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss506.Location = new System.Drawing.Point(4, 49);
            this.txtSchuss506.Name = "txtSchuss506";
            this.txtSchuss506.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss506.TabIndex = 0;
            this.txtSchuss506.Text = "1";
            this.txtSchuss506.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss516
            // 
            this.txtSchuss516.AutoSize = true;
            this.txtSchuss516.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss516.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss516.Location = new System.Drawing.Point(44, 49);
            this.txtSchuss516.Name = "txtSchuss516";
            this.txtSchuss516.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss516.TabIndex = 1;
            this.txtSchuss516.Text = "10";
            this.txtSchuss516.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss526
            // 
            this.txtSchuss526.AutoSize = true;
            this.txtSchuss526.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss526.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss526.Location = new System.Drawing.Point(84, 49);
            this.txtSchuss526.Name = "txtSchuss526";
            this.txtSchuss526.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss526.TabIndex = 0;
            this.txtSchuss526.Text = "1";
            this.txtSchuss526.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss536
            // 
            this.txtSchuss536.AutoSize = true;
            this.txtSchuss536.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss536.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss536.Location = new System.Drawing.Point(124, 49);
            this.txtSchuss536.Name = "txtSchuss536";
            this.txtSchuss536.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss536.TabIndex = 1;
            this.txtSchuss536.Text = "10";
            this.txtSchuss536.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss546
            // 
            this.txtSchuss546.AutoSize = true;
            this.txtSchuss546.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss546.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss546.Location = new System.Drawing.Point(164, 49);
            this.txtSchuss546.Name = "txtSchuss546";
            this.txtSchuss546.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss546.TabIndex = 0;
            this.txtSchuss546.Text = "1";
            this.txtSchuss546.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss507
            // 
            this.txtSchuss507.AutoSize = true;
            this.txtSchuss507.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss507.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss507.Location = new System.Drawing.Point(4, 57);
            this.txtSchuss507.Name = "txtSchuss507";
            this.txtSchuss507.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss507.TabIndex = 0;
            this.txtSchuss507.Text = "1";
            this.txtSchuss507.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss517
            // 
            this.txtSchuss517.AutoSize = true;
            this.txtSchuss517.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss517.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss517.Location = new System.Drawing.Point(44, 57);
            this.txtSchuss517.Name = "txtSchuss517";
            this.txtSchuss517.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss517.TabIndex = 1;
            this.txtSchuss517.Text = "10";
            this.txtSchuss517.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss527
            // 
            this.txtSchuss527.AutoSize = true;
            this.txtSchuss527.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss527.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss527.Location = new System.Drawing.Point(84, 57);
            this.txtSchuss527.Name = "txtSchuss527";
            this.txtSchuss527.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss527.TabIndex = 0;
            this.txtSchuss527.Text = "1";
            this.txtSchuss527.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss537
            // 
            this.txtSchuss537.AutoSize = true;
            this.txtSchuss537.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss537.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss537.Location = new System.Drawing.Point(124, 57);
            this.txtSchuss537.Name = "txtSchuss537";
            this.txtSchuss537.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss537.TabIndex = 1;
            this.txtSchuss537.Text = "10";
            this.txtSchuss537.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss547
            // 
            this.txtSchuss547.AutoSize = true;
            this.txtSchuss547.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss547.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss547.Location = new System.Drawing.Point(164, 57);
            this.txtSchuss547.Name = "txtSchuss547";
            this.txtSchuss547.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss547.TabIndex = 0;
            this.txtSchuss547.Text = "1";
            this.txtSchuss547.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Stand4SplitContainer
            // 
            this.Stand4SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stand4SplitContainer.Location = new System.Drawing.Point(6, 214);
            this.Stand4SplitContainer.Name = "Stand4SplitContainer";
            // 
            // Stand4SplitContainer.Panel1
            // 
            this.Stand4SplitContainer.Panel1.Controls.Add(this.stand4Zielscheibe);
            // 
            // Stand4SplitContainer.Panel2
            // 
            this.Stand4SplitContainer.Panel2.Controls.Add(this.lblProbe4);
            this.Stand4SplitContainer.Panel2.Controls.Add(this.Stand4SchussPanel);
            this.Stand4SplitContainer.Panel2.Controls.Add(this.lblSchussStand4);
            this.Stand4SplitContainer.Panel2.Controls.Add(this.txtSchussStand4);
            this.Stand4SplitContainer.Panel2.Controls.Add(this.lblDisziplinStand4);
            this.Stand4SplitContainer.Panel2.Controls.Add(this.txtDisziplinStand4);
            this.Stand4SplitContainer.Panel2.Controls.Add(this.lblSchuetzeStand4);
            this.Stand4SplitContainer.Panel2.Controls.Add(this.txtSchuetzeStand4);
            this.Stand4SplitContainer.Size = new System.Drawing.Size(307, 199);
            this.Stand4SplitContainer.SplitterDistance = 102;
            this.Stand4SplitContainer.TabIndex = 2;
            // 
            // stand4Zielscheibe
            // 
            this.stand4Zielscheibe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stand4Zielscheibe.Location = new System.Drawing.Point(0, 0);
            this.stand4Zielscheibe.Name = "stand4Zielscheibe";
            this.stand4Zielscheibe.Size = new System.Drawing.Size(102, 199);
            this.stand4Zielscheibe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stand4Zielscheibe.TabIndex = 1;
            this.stand4Zielscheibe.TabStop = false;
            this.stand4Zielscheibe.Paint += new System.Windows.Forms.PaintEventHandler(this.stand4Zielscheibe_Paint);
            this.stand4Zielscheibe.DoubleClick += new System.EventHandler(this.stand4Zielscheibe_DoubleClick);
            // 
            // lblProbe4
            // 
            this.lblProbe4.AutoSize = true;
            this.lblProbe4.Location = new System.Drawing.Point(-3, 113);
            this.lblProbe4.Name = "lblProbe4";
            this.lblProbe4.Size = new System.Drawing.Size(41, 13);
            this.lblProbe4.TabIndex = 36;
            this.lblProbe4.Text = "label17";
            // 
            // Stand4SchussPanel
            // 
            this.Stand4SchussPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Stand4SchussPanel.ColumnCount = 5;
            this.Stand4SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand4SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand4SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand4SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand4SchussPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss400, 0, 0);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss410, 1, 0);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss420, 2, 0);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss430, 3, 0);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss440, 4, 0);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss401, 0, 1);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss411, 1, 1);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss421, 2, 1);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss431, 3, 1);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss441, 4, 1);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss402, 0, 2);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss412, 1, 2);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss422, 2, 2);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss432, 3, 2);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss442, 4, 2);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss403, 0, 3);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss413, 1, 3);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss423, 2, 3);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss433, 3, 3);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss443, 4, 3);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss404, 0, 4);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss414, 1, 4);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss424, 2, 4);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss434, 3, 4);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss444, 4, 4);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss405, 0, 5);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss415, 1, 5);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss425, 2, 5);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss435, 3, 5);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss445, 4, 5);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss406, 0, 6);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss416, 1, 6);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss426, 2, 6);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss436, 3, 6);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss446, 4, 6);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss407, 0, 7);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss417, 1, 7);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss427, 2, 7);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss437, 3, 7);
            this.Stand4SchussPanel.Controls.Add(this.txtSchuss447, 4, 7);
            this.Stand4SchussPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Stand4SchussPanel.Location = new System.Drawing.Point(0, 129);
            this.Stand4SchussPanel.Name = "Stand4SchussPanel";
            this.Stand4SchussPanel.RowCount = 8;
            this.Stand4SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand4SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand4SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand4SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand4SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand4SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand4SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand4SchussPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Stand4SchussPanel.Size = new System.Drawing.Size(201, 70);
            this.Stand4SchussPanel.TabIndex = 6;
            // 
            // txtSchuss400
            // 
            this.txtSchuss400.AutoSize = true;
            this.txtSchuss400.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss400.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss400.Location = new System.Drawing.Point(4, 1);
            this.txtSchuss400.Name = "txtSchuss400";
            this.txtSchuss400.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss400.TabIndex = 0;
            this.txtSchuss400.Text = "1";
            this.txtSchuss400.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss410
            // 
            this.txtSchuss410.AutoSize = true;
            this.txtSchuss410.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss410.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss410.Location = new System.Drawing.Point(44, 1);
            this.txtSchuss410.Name = "txtSchuss410";
            this.txtSchuss410.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss410.TabIndex = 1;
            this.txtSchuss410.Text = "10";
            this.txtSchuss410.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss420
            // 
            this.txtSchuss420.AutoSize = true;
            this.txtSchuss420.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss420.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss420.Location = new System.Drawing.Point(84, 1);
            this.txtSchuss420.Name = "txtSchuss420";
            this.txtSchuss420.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss420.TabIndex = 0;
            this.txtSchuss420.Text = "1";
            this.txtSchuss420.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss430
            // 
            this.txtSchuss430.AutoSize = true;
            this.txtSchuss430.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss430.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss430.Location = new System.Drawing.Point(124, 1);
            this.txtSchuss430.Name = "txtSchuss430";
            this.txtSchuss430.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss430.TabIndex = 1;
            this.txtSchuss430.Text = "10";
            this.txtSchuss430.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss440
            // 
            this.txtSchuss440.AutoSize = true;
            this.txtSchuss440.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss440.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss440.Location = new System.Drawing.Point(164, 1);
            this.txtSchuss440.Name = "txtSchuss440";
            this.txtSchuss440.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss440.TabIndex = 0;
            this.txtSchuss440.Text = "1";
            this.txtSchuss440.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss401
            // 
            this.txtSchuss401.AutoSize = true;
            this.txtSchuss401.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss401.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss401.Location = new System.Drawing.Point(4, 9);
            this.txtSchuss401.Name = "txtSchuss401";
            this.txtSchuss401.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss401.TabIndex = 0;
            this.txtSchuss401.Text = "1";
            this.txtSchuss401.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss411
            // 
            this.txtSchuss411.AutoSize = true;
            this.txtSchuss411.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss411.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss411.Location = new System.Drawing.Point(44, 9);
            this.txtSchuss411.Name = "txtSchuss411";
            this.txtSchuss411.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss411.TabIndex = 1;
            this.txtSchuss411.Text = "10";
            this.txtSchuss411.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss421
            // 
            this.txtSchuss421.AutoSize = true;
            this.txtSchuss421.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss421.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss421.Location = new System.Drawing.Point(84, 9);
            this.txtSchuss421.Name = "txtSchuss421";
            this.txtSchuss421.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss421.TabIndex = 0;
            this.txtSchuss421.Text = "1";
            this.txtSchuss421.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss431
            // 
            this.txtSchuss431.AutoSize = true;
            this.txtSchuss431.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss431.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss431.Location = new System.Drawing.Point(124, 9);
            this.txtSchuss431.Name = "txtSchuss431";
            this.txtSchuss431.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss431.TabIndex = 1;
            this.txtSchuss431.Text = "10";
            this.txtSchuss431.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss441
            // 
            this.txtSchuss441.AutoSize = true;
            this.txtSchuss441.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss441.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss441.Location = new System.Drawing.Point(164, 9);
            this.txtSchuss441.Name = "txtSchuss441";
            this.txtSchuss441.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss441.TabIndex = 0;
            this.txtSchuss441.Text = "1";
            this.txtSchuss441.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss402
            // 
            this.txtSchuss402.AutoSize = true;
            this.txtSchuss402.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss402.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss402.Location = new System.Drawing.Point(4, 17);
            this.txtSchuss402.Name = "txtSchuss402";
            this.txtSchuss402.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss402.TabIndex = 0;
            this.txtSchuss402.Text = "1";
            this.txtSchuss402.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss412
            // 
            this.txtSchuss412.AutoSize = true;
            this.txtSchuss412.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss412.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss412.Location = new System.Drawing.Point(44, 17);
            this.txtSchuss412.Name = "txtSchuss412";
            this.txtSchuss412.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss412.TabIndex = 1;
            this.txtSchuss412.Text = "10";
            this.txtSchuss412.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss422
            // 
            this.txtSchuss422.AutoSize = true;
            this.txtSchuss422.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss422.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss422.Location = new System.Drawing.Point(84, 17);
            this.txtSchuss422.Name = "txtSchuss422";
            this.txtSchuss422.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss422.TabIndex = 0;
            this.txtSchuss422.Text = "1";
            this.txtSchuss422.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss432
            // 
            this.txtSchuss432.AutoSize = true;
            this.txtSchuss432.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss432.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss432.Location = new System.Drawing.Point(124, 17);
            this.txtSchuss432.Name = "txtSchuss432";
            this.txtSchuss432.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss432.TabIndex = 1;
            this.txtSchuss432.Text = "10";
            this.txtSchuss432.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss442
            // 
            this.txtSchuss442.AutoSize = true;
            this.txtSchuss442.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss442.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss442.Location = new System.Drawing.Point(164, 17);
            this.txtSchuss442.Name = "txtSchuss442";
            this.txtSchuss442.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss442.TabIndex = 0;
            this.txtSchuss442.Text = "1";
            this.txtSchuss442.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss403
            // 
            this.txtSchuss403.AutoSize = true;
            this.txtSchuss403.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss403.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss403.Location = new System.Drawing.Point(4, 25);
            this.txtSchuss403.Name = "txtSchuss403";
            this.txtSchuss403.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss403.TabIndex = 0;
            this.txtSchuss403.Text = "1";
            this.txtSchuss403.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss413
            // 
            this.txtSchuss413.AutoSize = true;
            this.txtSchuss413.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss413.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss413.Location = new System.Drawing.Point(44, 25);
            this.txtSchuss413.Name = "txtSchuss413";
            this.txtSchuss413.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss413.TabIndex = 1;
            this.txtSchuss413.Text = "10";
            this.txtSchuss413.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss423
            // 
            this.txtSchuss423.AutoSize = true;
            this.txtSchuss423.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss423.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss423.Location = new System.Drawing.Point(84, 25);
            this.txtSchuss423.Name = "txtSchuss423";
            this.txtSchuss423.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss423.TabIndex = 0;
            this.txtSchuss423.Text = "1";
            this.txtSchuss423.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss433
            // 
            this.txtSchuss433.AutoSize = true;
            this.txtSchuss433.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss433.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss433.Location = new System.Drawing.Point(124, 25);
            this.txtSchuss433.Name = "txtSchuss433";
            this.txtSchuss433.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss433.TabIndex = 1;
            this.txtSchuss433.Text = "10";
            this.txtSchuss433.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss443
            // 
            this.txtSchuss443.AutoSize = true;
            this.txtSchuss443.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss443.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss443.Location = new System.Drawing.Point(164, 25);
            this.txtSchuss443.Name = "txtSchuss443";
            this.txtSchuss443.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss443.TabIndex = 0;
            this.txtSchuss443.Text = "1";
            this.txtSchuss443.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss404
            // 
            this.txtSchuss404.AutoSize = true;
            this.txtSchuss404.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss404.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss404.Location = new System.Drawing.Point(4, 33);
            this.txtSchuss404.Name = "txtSchuss404";
            this.txtSchuss404.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss404.TabIndex = 0;
            this.txtSchuss404.Text = "1";
            this.txtSchuss404.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss414
            // 
            this.txtSchuss414.AutoSize = true;
            this.txtSchuss414.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss414.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss414.Location = new System.Drawing.Point(44, 33);
            this.txtSchuss414.Name = "txtSchuss414";
            this.txtSchuss414.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss414.TabIndex = 1;
            this.txtSchuss414.Text = "10";
            this.txtSchuss414.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss424
            // 
            this.txtSchuss424.AutoSize = true;
            this.txtSchuss424.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss424.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss424.Location = new System.Drawing.Point(84, 33);
            this.txtSchuss424.Name = "txtSchuss424";
            this.txtSchuss424.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss424.TabIndex = 0;
            this.txtSchuss424.Text = "1";
            this.txtSchuss424.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss434
            // 
            this.txtSchuss434.AutoSize = true;
            this.txtSchuss434.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss434.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss434.Location = new System.Drawing.Point(124, 33);
            this.txtSchuss434.Name = "txtSchuss434";
            this.txtSchuss434.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss434.TabIndex = 1;
            this.txtSchuss434.Text = "10";
            this.txtSchuss434.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss444
            // 
            this.txtSchuss444.AutoSize = true;
            this.txtSchuss444.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss444.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss444.Location = new System.Drawing.Point(164, 33);
            this.txtSchuss444.Name = "txtSchuss444";
            this.txtSchuss444.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss444.TabIndex = 0;
            this.txtSchuss444.Text = "1";
            this.txtSchuss444.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss405
            // 
            this.txtSchuss405.AutoSize = true;
            this.txtSchuss405.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss405.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss405.Location = new System.Drawing.Point(4, 41);
            this.txtSchuss405.Name = "txtSchuss405";
            this.txtSchuss405.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss405.TabIndex = 0;
            this.txtSchuss405.Text = "1";
            this.txtSchuss405.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss415
            // 
            this.txtSchuss415.AutoSize = true;
            this.txtSchuss415.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss415.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss415.Location = new System.Drawing.Point(44, 41);
            this.txtSchuss415.Name = "txtSchuss415";
            this.txtSchuss415.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss415.TabIndex = 1;
            this.txtSchuss415.Text = "10";
            this.txtSchuss415.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss425
            // 
            this.txtSchuss425.AutoSize = true;
            this.txtSchuss425.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss425.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss425.Location = new System.Drawing.Point(84, 41);
            this.txtSchuss425.Name = "txtSchuss425";
            this.txtSchuss425.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss425.TabIndex = 0;
            this.txtSchuss425.Text = "1";
            this.txtSchuss425.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss435
            // 
            this.txtSchuss435.AutoSize = true;
            this.txtSchuss435.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss435.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss435.Location = new System.Drawing.Point(124, 41);
            this.txtSchuss435.Name = "txtSchuss435";
            this.txtSchuss435.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss435.TabIndex = 1;
            this.txtSchuss435.Text = "10";
            this.txtSchuss435.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss445
            // 
            this.txtSchuss445.AutoSize = true;
            this.txtSchuss445.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss445.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss445.Location = new System.Drawing.Point(164, 41);
            this.txtSchuss445.Name = "txtSchuss445";
            this.txtSchuss445.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss445.TabIndex = 0;
            this.txtSchuss445.Text = "1";
            this.txtSchuss445.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss406
            // 
            this.txtSchuss406.AutoSize = true;
            this.txtSchuss406.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss406.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss406.Location = new System.Drawing.Point(4, 49);
            this.txtSchuss406.Name = "txtSchuss406";
            this.txtSchuss406.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss406.TabIndex = 0;
            this.txtSchuss406.Text = "1";
            this.txtSchuss406.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss416
            // 
            this.txtSchuss416.AutoSize = true;
            this.txtSchuss416.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss416.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss416.Location = new System.Drawing.Point(44, 49);
            this.txtSchuss416.Name = "txtSchuss416";
            this.txtSchuss416.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss416.TabIndex = 1;
            this.txtSchuss416.Text = "10";
            this.txtSchuss416.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss426
            // 
            this.txtSchuss426.AutoSize = true;
            this.txtSchuss426.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss426.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss426.Location = new System.Drawing.Point(84, 49);
            this.txtSchuss426.Name = "txtSchuss426";
            this.txtSchuss426.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss426.TabIndex = 0;
            this.txtSchuss426.Text = "1";
            this.txtSchuss426.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss436
            // 
            this.txtSchuss436.AutoSize = true;
            this.txtSchuss436.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss436.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss436.Location = new System.Drawing.Point(124, 49);
            this.txtSchuss436.Name = "txtSchuss436";
            this.txtSchuss436.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss436.TabIndex = 1;
            this.txtSchuss436.Text = "10";
            this.txtSchuss436.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss446
            // 
            this.txtSchuss446.AutoSize = true;
            this.txtSchuss446.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss446.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss446.Location = new System.Drawing.Point(164, 49);
            this.txtSchuss446.Name = "txtSchuss446";
            this.txtSchuss446.Size = new System.Drawing.Size(33, 7);
            this.txtSchuss446.TabIndex = 0;
            this.txtSchuss446.Text = "1";
            this.txtSchuss446.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss407
            // 
            this.txtSchuss407.AutoSize = true;
            this.txtSchuss407.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss407.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss407.Location = new System.Drawing.Point(4, 57);
            this.txtSchuss407.Name = "txtSchuss407";
            this.txtSchuss407.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss407.TabIndex = 0;
            this.txtSchuss407.Text = "1";
            this.txtSchuss407.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss417
            // 
            this.txtSchuss417.AutoSize = true;
            this.txtSchuss417.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss417.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss417.Location = new System.Drawing.Point(44, 57);
            this.txtSchuss417.Name = "txtSchuss417";
            this.txtSchuss417.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss417.TabIndex = 1;
            this.txtSchuss417.Text = "10";
            this.txtSchuss417.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss427
            // 
            this.txtSchuss427.AutoSize = true;
            this.txtSchuss427.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss427.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss427.Location = new System.Drawing.Point(84, 57);
            this.txtSchuss427.Name = "txtSchuss427";
            this.txtSchuss427.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss427.TabIndex = 0;
            this.txtSchuss427.Text = "1";
            this.txtSchuss427.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss437
            // 
            this.txtSchuss437.AutoSize = true;
            this.txtSchuss437.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss437.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss437.Location = new System.Drawing.Point(124, 57);
            this.txtSchuss437.Name = "txtSchuss437";
            this.txtSchuss437.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss437.TabIndex = 1;
            this.txtSchuss437.Text = "10";
            this.txtSchuss437.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchuss447
            // 
            this.txtSchuss447.AutoSize = true;
            this.txtSchuss447.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchuss447.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchuss447.Location = new System.Drawing.Point(164, 57);
            this.txtSchuss447.Name = "txtSchuss447";
            this.txtSchuss447.Size = new System.Drawing.Size(33, 12);
            this.txtSchuss447.TabIndex = 0;
            this.txtSchuss447.Text = "1";
            this.txtSchuss447.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSchussStand4
            // 
            this.lblSchussStand4.AutoSize = true;
            this.lblSchussStand4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchussStand4.Location = new System.Drawing.Point(-3, 68);
            this.lblSchussStand4.Name = "lblSchussStand4";
            this.lblSchussStand4.Size = new System.Drawing.Size(51, 13);
            this.lblSchussStand4.TabIndex = 5;
            this.lblSchussStand4.Text = "Summe:";
            // 
            // txtSchussStand4
            // 
            this.txtSchussStand4.AutoSize = true;
            this.txtSchussStand4.Location = new System.Drawing.Point(-3, 81);
            this.txtSchussStand4.Name = "txtSchussStand4";
            this.txtSchussStand4.Size = new System.Drawing.Size(0, 13);
            this.txtSchussStand4.TabIndex = 4;
            // 
            // lblDisziplinStand4
            // 
            this.lblDisziplinStand4.AutoSize = true;
            this.lblDisziplinStand4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisziplinStand4.Location = new System.Drawing.Point(-3, 26);
            this.lblDisziplinStand4.Name = "lblDisziplinStand4";
            this.lblDisziplinStand4.Size = new System.Drawing.Size(54, 13);
            this.lblDisziplinStand4.TabIndex = 3;
            this.lblDisziplinStand4.Text = "Disziplin";
            // 
            // txtDisziplinStand4
            // 
            this.txtDisziplinStand4.AutoSize = true;
            this.txtDisziplinStand4.Location = new System.Drawing.Point(-3, 39);
            this.txtDisziplinStand4.Name = "txtDisziplinStand4";
            this.txtDisziplinStand4.Size = new System.Drawing.Size(0, 13);
            this.txtDisziplinStand4.TabIndex = 2;
            // 
            // lblSchuetzeStand4
            // 
            this.lblSchuetzeStand4.AutoSize = true;
            this.lblSchuetzeStand4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchuetzeStand4.Location = new System.Drawing.Point(-3, 0);
            this.lblSchuetzeStand4.Name = "lblSchuetzeStand4";
            this.lblSchuetzeStand4.Size = new System.Drawing.Size(53, 13);
            this.lblSchuetzeStand4.TabIndex = 1;
            this.lblSchuetzeStand4.Text = "Schütze";
            // 
            // txtSchuetzeStand4
            // 
            this.txtSchuetzeStand4.AutoSize = true;
            this.txtSchuetzeStand4.Location = new System.Drawing.Point(-3, 13);
            this.txtSchuetzeStand4.Name = "txtSchuetzeStand4";
            this.txtSchuetzeStand4.Size = new System.Drawing.Size(0, 13);
            this.txtSchuetzeStand4.TabIndex = 0;
            // 
            // wanderpokal
            // 
            this.wanderpokal.BackColor = System.Drawing.SystemColors.Control;
            this.wanderpokal.Controls.Add(this.tableLayoutPanel8);
            this.wanderpokal.Controls.Add(this.button3);
            this.wanderpokal.Controls.Add(this.button2);
            this.wanderpokal.Controls.Add(this.labelTermin2);
            this.wanderpokal.Controls.Add(this.dateTimeWPTermin2);
            this.wanderpokal.Controls.Add(this.labelTermin3);
            this.wanderpokal.Controls.Add(this.dateTimeWPTermin3);
            this.wanderpokal.Controls.Add(this.labelTermin4);
            this.wanderpokal.Controls.Add(this.dateTimeWPTermin4);
            this.wanderpokal.Controls.Add(this.labelTermin5);
            this.wanderpokal.Controls.Add(this.dateTimeWPTermin5);
            this.wanderpokal.Controls.Add(this.labelTermin6);
            this.wanderpokal.Controls.Add(this.dateTimeWPTermin6);
            this.wanderpokal.Controls.Add(this.labelTermin7);
            this.wanderpokal.Controls.Add(this.dateTimeWPTermin7);
            this.wanderpokal.Controls.Add(this.labelTermin8);
            this.wanderpokal.Controls.Add(this.dateTimeWPTermin8);
            this.wanderpokal.Controls.Add(this.labelTermin9);
            this.wanderpokal.Controls.Add(this.dateTimeWPTermin9);
            this.wanderpokal.Controls.Add(this.labelTermin10);
            this.wanderpokal.Controls.Add(this.dateTimeWPTermin10);
            this.wanderpokal.Controls.Add(this.labelTermin11);
            this.wanderpokal.Controls.Add(this.dateTimeWPTermin11);
            this.wanderpokal.Controls.Add(this.labelTermin12);
            this.wanderpokal.Controls.Add(this.dateTimeWPTermin12);
            this.wanderpokal.Controls.Add(this.labelTermin1);
            this.wanderpokal.Controls.Add(this.dateTimeWPTermin1);
            this.wanderpokal.Location = new System.Drawing.Point(4, 22);
            this.wanderpokal.Name = "wanderpokal";
            this.wanderpokal.Padding = new System.Windows.Forms.Padding(3);
            this.wanderpokal.Size = new System.Drawing.Size(952, 419);
            this.wanderpokal.TabIndex = 5;
            this.wanderpokal.Text = "Jahrespokal";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.JahrespokalErwachseneDGV, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.JahrespokalJugendDGV, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.labelWPSK, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(269, 6);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.Size = new System.Drawing.Size(677, 407);
            this.tableLayoutPanel8.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Jahrespokal Jugend";
            // 
            // JahrespokalErwachseneDGV
            // 
            this.JahrespokalErwachseneDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.JahrespokalErwachseneDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JahrespokalErwachseneDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JahrespokalErwachseneDGV.Location = new System.Drawing.Point(3, 16);
            this.JahrespokalErwachseneDGV.Name = "JahrespokalErwachseneDGV";
            this.JahrespokalErwachseneDGV.Size = new System.Drawing.Size(332, 401);
            this.JahrespokalErwachseneDGV.TabIndex = 0;
            // 
            // JahrespokalJugendDGV
            // 
            this.JahrespokalJugendDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.JahrespokalJugendDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JahrespokalJugendDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JahrespokalJugendDGV.Location = new System.Drawing.Point(341, 16);
            this.JahrespokalJugendDGV.Name = "JahrespokalJugendDGV";
            this.JahrespokalJugendDGV.Size = new System.Drawing.Size(333, 401);
            this.JahrespokalJugendDGV.TabIndex = 1;
            // 
            // labelWPSK
            // 
            this.labelWPSK.AutoSize = true;
            this.labelWPSK.Location = new System.Drawing.Point(3, 0);
            this.labelWPSK.Name = "labelWPSK";
            this.labelWPSK.Size = new System.Drawing.Size(126, 13);
            this.labelWPSK.TabIndex = 5;
            this.labelWPSK.Text = "Jahrespokal Erwachsene";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(254, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Termine speichern / aktualisieren";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "letzter Freitag im Monat - 1 Jahr";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelTermin2
            // 
            this.labelTermin2.AutoSize = true;
            this.labelTermin2.Location = new System.Drawing.Point(6, 38);
            this.labelTermin2.Name = "labelTermin2";
            this.labelTermin2.Size = new System.Drawing.Size(51, 13);
            this.labelTermin2.TabIndex = 23;
            this.labelTermin2.Text = "Termin 2:";
            // 
            // dateTimeWPTermin2
            // 
            this.dateTimeWPTermin2.Location = new System.Drawing.Point(63, 32);
            this.dateTimeWPTermin2.Name = "dateTimeWPTermin2";
            this.dateTimeWPTermin2.Size = new System.Drawing.Size(200, 20);
            this.dateTimeWPTermin2.TabIndex = 22;
            // 
            // labelTermin3
            // 
            this.labelTermin3.AutoSize = true;
            this.labelTermin3.Location = new System.Drawing.Point(6, 64);
            this.labelTermin3.Name = "labelTermin3";
            this.labelTermin3.Size = new System.Drawing.Size(51, 13);
            this.labelTermin3.TabIndex = 21;
            this.labelTermin3.Text = "Termin 3:";
            // 
            // dateTimeWPTermin3
            // 
            this.dateTimeWPTermin3.Location = new System.Drawing.Point(63, 58);
            this.dateTimeWPTermin3.Name = "dateTimeWPTermin3";
            this.dateTimeWPTermin3.Size = new System.Drawing.Size(200, 20);
            this.dateTimeWPTermin3.TabIndex = 20;
            // 
            // labelTermin4
            // 
            this.labelTermin4.AutoSize = true;
            this.labelTermin4.Location = new System.Drawing.Point(6, 90);
            this.labelTermin4.Name = "labelTermin4";
            this.labelTermin4.Size = new System.Drawing.Size(51, 13);
            this.labelTermin4.TabIndex = 19;
            this.labelTermin4.Text = "Termin 4:";
            // 
            // dateTimeWPTermin4
            // 
            this.dateTimeWPTermin4.Location = new System.Drawing.Point(63, 84);
            this.dateTimeWPTermin4.Name = "dateTimeWPTermin4";
            this.dateTimeWPTermin4.Size = new System.Drawing.Size(200, 20);
            this.dateTimeWPTermin4.TabIndex = 18;
            // 
            // labelTermin5
            // 
            this.labelTermin5.AutoSize = true;
            this.labelTermin5.Location = new System.Drawing.Point(6, 116);
            this.labelTermin5.Name = "labelTermin5";
            this.labelTermin5.Size = new System.Drawing.Size(51, 13);
            this.labelTermin5.TabIndex = 17;
            this.labelTermin5.Text = "Termin 5:";
            // 
            // dateTimeWPTermin5
            // 
            this.dateTimeWPTermin5.Location = new System.Drawing.Point(63, 110);
            this.dateTimeWPTermin5.Name = "dateTimeWPTermin5";
            this.dateTimeWPTermin5.Size = new System.Drawing.Size(200, 20);
            this.dateTimeWPTermin5.TabIndex = 16;
            // 
            // labelTermin6
            // 
            this.labelTermin6.AutoSize = true;
            this.labelTermin6.Location = new System.Drawing.Point(6, 142);
            this.labelTermin6.Name = "labelTermin6";
            this.labelTermin6.Size = new System.Drawing.Size(51, 13);
            this.labelTermin6.TabIndex = 15;
            this.labelTermin6.Text = "Termin 6:";
            // 
            // dateTimeWPTermin6
            // 
            this.dateTimeWPTermin6.Location = new System.Drawing.Point(63, 136);
            this.dateTimeWPTermin6.Name = "dateTimeWPTermin6";
            this.dateTimeWPTermin6.Size = new System.Drawing.Size(200, 20);
            this.dateTimeWPTermin6.TabIndex = 14;
            // 
            // labelTermin7
            // 
            this.labelTermin7.AutoSize = true;
            this.labelTermin7.Location = new System.Drawing.Point(6, 168);
            this.labelTermin7.Name = "labelTermin7";
            this.labelTermin7.Size = new System.Drawing.Size(51, 13);
            this.labelTermin7.TabIndex = 13;
            this.labelTermin7.Text = "Termin 7:";
            // 
            // dateTimeWPTermin7
            // 
            this.dateTimeWPTermin7.Location = new System.Drawing.Point(63, 162);
            this.dateTimeWPTermin7.Name = "dateTimeWPTermin7";
            this.dateTimeWPTermin7.Size = new System.Drawing.Size(200, 20);
            this.dateTimeWPTermin7.TabIndex = 12;
            // 
            // labelTermin8
            // 
            this.labelTermin8.AutoSize = true;
            this.labelTermin8.Location = new System.Drawing.Point(6, 194);
            this.labelTermin8.Name = "labelTermin8";
            this.labelTermin8.Size = new System.Drawing.Size(51, 13);
            this.labelTermin8.TabIndex = 11;
            this.labelTermin8.Text = "Termin 8:";
            // 
            // dateTimeWPTermin8
            // 
            this.dateTimeWPTermin8.Location = new System.Drawing.Point(63, 188);
            this.dateTimeWPTermin8.Name = "dateTimeWPTermin8";
            this.dateTimeWPTermin8.Size = new System.Drawing.Size(200, 20);
            this.dateTimeWPTermin8.TabIndex = 10;
            // 
            // labelTermin9
            // 
            this.labelTermin9.AutoSize = true;
            this.labelTermin9.Location = new System.Drawing.Point(6, 220);
            this.labelTermin9.Name = "labelTermin9";
            this.labelTermin9.Size = new System.Drawing.Size(51, 13);
            this.labelTermin9.TabIndex = 9;
            this.labelTermin9.Text = "Termin 9:";
            // 
            // dateTimeWPTermin9
            // 
            this.dateTimeWPTermin9.Location = new System.Drawing.Point(63, 214);
            this.dateTimeWPTermin9.Name = "dateTimeWPTermin9";
            this.dateTimeWPTermin9.Size = new System.Drawing.Size(200, 20);
            this.dateTimeWPTermin9.TabIndex = 8;
            // 
            // labelTermin10
            // 
            this.labelTermin10.AutoSize = true;
            this.labelTermin10.Location = new System.Drawing.Point(6, 246);
            this.labelTermin10.Name = "labelTermin10";
            this.labelTermin10.Size = new System.Drawing.Size(57, 13);
            this.labelTermin10.TabIndex = 7;
            this.labelTermin10.Text = "Termin 10:";
            // 
            // dateTimeWPTermin10
            // 
            this.dateTimeWPTermin10.Location = new System.Drawing.Point(63, 240);
            this.dateTimeWPTermin10.Name = "dateTimeWPTermin10";
            this.dateTimeWPTermin10.Size = new System.Drawing.Size(200, 20);
            this.dateTimeWPTermin10.TabIndex = 6;
            // 
            // labelTermin11
            // 
            this.labelTermin11.AutoSize = true;
            this.labelTermin11.Location = new System.Drawing.Point(6, 272);
            this.labelTermin11.Name = "labelTermin11";
            this.labelTermin11.Size = new System.Drawing.Size(57, 13);
            this.labelTermin11.TabIndex = 5;
            this.labelTermin11.Text = "Termin 11:";
            // 
            // dateTimeWPTermin11
            // 
            this.dateTimeWPTermin11.Location = new System.Drawing.Point(63, 266);
            this.dateTimeWPTermin11.Name = "dateTimeWPTermin11";
            this.dateTimeWPTermin11.Size = new System.Drawing.Size(200, 20);
            this.dateTimeWPTermin11.TabIndex = 4;
            // 
            // labelTermin12
            // 
            this.labelTermin12.AutoSize = true;
            this.labelTermin12.Location = new System.Drawing.Point(6, 298);
            this.labelTermin12.Name = "labelTermin12";
            this.labelTermin12.Size = new System.Drawing.Size(57, 13);
            this.labelTermin12.TabIndex = 3;
            this.labelTermin12.Text = "Termin 12:";
            // 
            // dateTimeWPTermin12
            // 
            this.dateTimeWPTermin12.Location = new System.Drawing.Point(63, 292);
            this.dateTimeWPTermin12.Name = "dateTimeWPTermin12";
            this.dateTimeWPTermin12.Size = new System.Drawing.Size(200, 20);
            this.dateTimeWPTermin12.TabIndex = 2;
            // 
            // labelTermin1
            // 
            this.labelTermin1.AutoSize = true;
            this.labelTermin1.Location = new System.Drawing.Point(6, 12);
            this.labelTermin1.Name = "labelTermin1";
            this.labelTermin1.Size = new System.Drawing.Size(51, 13);
            this.labelTermin1.TabIndex = 1;
            this.labelTermin1.Text = "Termin 1:";
            // 
            // dateTimeWPTermin1
            // 
            this.dateTimeWPTermin1.Location = new System.Drawing.Point(63, 6);
            this.dateTimeWPTermin1.Name = "dateTimeWPTermin1";
            this.dateTimeWPTermin1.Size = new System.Drawing.Size(200, 20);
            this.dateTimeWPTermin1.TabIndex = 0;
            // 
            // KoenigTab
            // 
            this.KoenigTab.Controls.Add(this.splitContainerKoenig1);
            this.KoenigTab.Location = new System.Drawing.Point(4, 22);
            this.KoenigTab.Name = "KoenigTab";
            this.KoenigTab.Padding = new System.Windows.Forms.Padding(3);
            this.KoenigTab.Size = new System.Drawing.Size(952, 419);
            this.KoenigTab.TabIndex = 4;
            this.KoenigTab.Text = "König";
            this.KoenigTab.UseVisualStyleBackColor = true;
            // 
            // splitContainerKoenig1
            // 
            this.splitContainerKoenig1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerKoenig1.Location = new System.Drawing.Point(3, 3);
            this.splitContainerKoenig1.Name = "splitContainerKoenig1";
            // 
            // splitContainerKoenig1.Panel1
            // 
            this.splitContainerKoenig1.Panel1.Controls.Add(this.splitContainerKoenig2);
            // 
            // splitContainerKoenig1.Panel2
            // 
            this.splitContainerKoenig1.Panel2.Controls.Add(this.splitContainerKoenig3);
            this.splitContainerKoenig1.Size = new System.Drawing.Size(946, 413);
            this.splitContainerKoenig1.SplitterDistance = 371;
            this.splitContainerKoenig1.TabIndex = 0;
            this.splitContainerKoenig1.Resize += new System.EventHandler(this.splitContainer1_Resize);
            // 
            // splitContainerKoenig2
            // 
            this.splitContainerKoenig2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerKoenig2.IsSplitterFixed = true;
            this.splitContainerKoenig2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerKoenig2.Name = "splitContainerKoenig2";
            this.splitContainerKoenig2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerKoenig2.Panel1
            // 
            this.splitContainerKoenig2.Panel1.Controls.Add(this.tableLayoutPanel4);
            // 
            // splitContainerKoenig2.Panel2
            // 
            this.splitContainerKoenig2.Panel2.Controls.Add(this.tableLayoutPanel5);
            this.splitContainerKoenig2.Size = new System.Drawing.Size(371, 413);
            this.splitContainerKoenig2.SplitterDistance = 174;
            this.splitContainerKoenig2.TabIndex = 0;
            this.splitContainerKoenig2.Resize += new System.EventHandler(this.splitContainer2_Resize);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.SchuetzenklasseLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.KoenigSKGridView, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(371, 174);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // SchuetzenklasseLabel
            // 
            this.SchuetzenklasseLabel.AutoSize = true;
            this.SchuetzenklasseLabel.Location = new System.Drawing.Point(3, 0);
            this.SchuetzenklasseLabel.Name = "SchuetzenklasseLabel";
            this.SchuetzenklasseLabel.Size = new System.Drawing.Size(112, 13);
            this.SchuetzenklasseLabel.TabIndex = 0;
            this.SchuetzenklasseLabel.Text = "König Schützenklasse";
            // 
            // KoenigSKGridView
            // 
            this.KoenigSKGridView.AllowUserToAddRows = false;
            this.KoenigSKGridView.AllowUserToDeleteRows = false;
            this.KoenigSKGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KoenigSKGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Position,
            this.Fullname,
            this.Datum,
            this.Teiler,
            this.Typ});
            this.KoenigSKGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KoenigSKGridView.Location = new System.Drawing.Point(3, 16);
            this.KoenigSKGridView.Name = "KoenigSKGridView";
            this.KoenigSKGridView.ReadOnly = true;
            this.KoenigSKGridView.RowHeadersVisible = false;
            this.KoenigSKGridView.Size = new System.Drawing.Size(365, 155);
            this.KoenigSKGridView.TabIndex = 1;
            this.KoenigSKGridView.Resize += new System.EventHandler(this.KoenigSKGridView_Resize);
            // 
            // Position
            // 
            this.Position.HeaderText = "Pos.";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 30;
            // 
            // Fullname
            // 
            this.Fullname.HeaderText = "Name";
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            // 
            // Datum
            // 
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Datum.DefaultCellStyle = dataGridViewCellStyle61;
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Teiler
            // 
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Teiler.DefaultCellStyle = dataGridViewCellStyle62;
            this.Teiler.HeaderText = "Teiler";
            this.Teiler.Name = "Teiler";
            this.Teiler.ReadOnly = true;
            this.Teiler.Width = 40;
            // 
            // Typ
            // 
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Typ.DefaultCellStyle = dataGridViewCellStyle63;
            this.Typ.HeaderText = "Typ";
            this.Typ.Name = "Typ";
            this.Typ.ReadOnly = true;
            this.Typ.Width = 30;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.SchuetzenlieslLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.KoenigDKGridView, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(371, 235);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // SchuetzenlieslLabel
            // 
            this.SchuetzenlieslLabel.AutoSize = true;
            this.SchuetzenlieslLabel.Location = new System.Drawing.Point(3, 0);
            this.SchuetzenlieslLabel.Name = "SchuetzenlieslLabel";
            this.SchuetzenlieslLabel.Size = new System.Drawing.Size(95, 13);
            this.SchuetzenlieslLabel.TabIndex = 1;
            this.SchuetzenlieslLabel.Text = "Liesl Damenklasse";
            // 
            // KoenigDKGridView
            // 
            this.KoenigDKGridView.AllowUserToAddRows = false;
            this.KoenigDKGridView.AllowUserToDeleteRows = false;
            this.KoenigDKGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KoenigDKGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PositionDK,
            this.FullnameDK,
            this.DatumDK,
            this.TeilerDK,
            this.TypDK});
            this.KoenigDKGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KoenigDKGridView.Location = new System.Drawing.Point(3, 16);
            this.KoenigDKGridView.Name = "KoenigDKGridView";
            this.KoenigDKGridView.ReadOnly = true;
            this.KoenigDKGridView.RowHeadersVisible = false;
            this.KoenigDKGridView.Size = new System.Drawing.Size(365, 216);
            this.KoenigDKGridView.TabIndex = 2;
            this.KoenigDKGridView.Resize += new System.EventHandler(this.KoenigSKGridView_Resize);
            // 
            // PositionDK
            // 
            this.PositionDK.HeaderText = "Pos.";
            this.PositionDK.Name = "PositionDK";
            this.PositionDK.ReadOnly = true;
            this.PositionDK.Width = 30;
            // 
            // FullnameDK
            // 
            this.FullnameDK.HeaderText = "Name";
            this.FullnameDK.Name = "FullnameDK";
            this.FullnameDK.ReadOnly = true;
            // 
            // DatumDK
            // 
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DatumDK.DefaultCellStyle = dataGridViewCellStyle64;
            this.DatumDK.HeaderText = "Datum";
            this.DatumDK.Name = "DatumDK";
            this.DatumDK.ReadOnly = true;
            // 
            // TeilerDK
            // 
            dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TeilerDK.DefaultCellStyle = dataGridViewCellStyle65;
            this.TeilerDK.HeaderText = "Teiler";
            this.TeilerDK.Name = "TeilerDK";
            this.TeilerDK.ReadOnly = true;
            this.TeilerDK.Width = 40;
            // 
            // TypDK
            // 
            dataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TypDK.DefaultCellStyle = dataGridViewCellStyle66;
            this.TypDK.HeaderText = "Typ";
            this.TypDK.Name = "TypDK";
            this.TypDK.ReadOnly = true;
            this.TypDK.Width = 30;
            // 
            // splitContainerKoenig3
            // 
            this.splitContainerKoenig3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerKoenig3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerKoenig3.Name = "splitContainerKoenig3";
            this.splitContainerKoenig3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerKoenig3.Panel1
            // 
            this.splitContainerKoenig3.Panel1.Controls.Add(this.tableLayoutPanel6);
            // 
            // splitContainerKoenig3.Panel2
            // 
            this.splitContainerKoenig3.Panel2.Controls.Add(this.tableLayoutPanel7);
            this.splitContainerKoenig3.Size = new System.Drawing.Size(571, 413);
            this.splitContainerKoenig3.SplitterDistance = 190;
            this.splitContainerKoenig3.TabIndex = 0;
            this.splitContainerKoenig3.Resize += new System.EventHandler(this.splitContainer3_Resize);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.KoenigAuflageGridView, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(571, 190);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "König Auflage";
            // 
            // KoenigAuflageGridView
            // 
            this.KoenigAuflageGridView.AllowUserToAddRows = false;
            this.KoenigAuflageGridView.AllowUserToDeleteRows = false;
            this.KoenigAuflageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KoenigAuflageGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PositionAuflage,
            this.FullnameAuflage,
            this.DatumAuflage,
            this.TeilerAuflage,
            this.TypAuflage});
            this.KoenigAuflageGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KoenigAuflageGridView.Location = new System.Drawing.Point(3, 16);
            this.KoenigAuflageGridView.Name = "KoenigAuflageGridView";
            this.KoenigAuflageGridView.ReadOnly = true;
            this.KoenigAuflageGridView.RowHeadersVisible = false;
            this.KoenigAuflageGridView.Size = new System.Drawing.Size(565, 171);
            this.KoenigAuflageGridView.TabIndex = 3;
            this.KoenigAuflageGridView.Resize += new System.EventHandler(this.KoenigSKGridView_Resize);
            // 
            // PositionAuflage
            // 
            this.PositionAuflage.HeaderText = "Pos.";
            this.PositionAuflage.Name = "PositionAuflage";
            this.PositionAuflage.ReadOnly = true;
            this.PositionAuflage.Width = 30;
            // 
            // FullnameAuflage
            // 
            this.FullnameAuflage.HeaderText = "Name";
            this.FullnameAuflage.Name = "FullnameAuflage";
            this.FullnameAuflage.ReadOnly = true;
            // 
            // DatumAuflage
            // 
            dataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DatumAuflage.DefaultCellStyle = dataGridViewCellStyle67;
            this.DatumAuflage.HeaderText = "Datum";
            this.DatumAuflage.Name = "DatumAuflage";
            this.DatumAuflage.ReadOnly = true;
            // 
            // TeilerAuflage
            // 
            dataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TeilerAuflage.DefaultCellStyle = dataGridViewCellStyle68;
            this.TeilerAuflage.HeaderText = "Teiler";
            this.TeilerAuflage.Name = "TeilerAuflage";
            this.TeilerAuflage.ReadOnly = true;
            this.TeilerAuflage.Width = 40;
            // 
            // TypAuflage
            // 
            dataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TypAuflage.DefaultCellStyle = dataGridViewCellStyle69;
            this.TypAuflage.HeaderText = "Typ";
            this.TypAuflage.Name = "TypAuflage";
            this.TypAuflage.ReadOnly = true;
            this.TypAuflage.Width = 30;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.KoenigJUGGridView, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(571, 219);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "König Jugend";
            // 
            // KoenigJUGGridView
            // 
            this.KoenigJUGGridView.AllowUserToAddRows = false;
            this.KoenigJUGGridView.AllowUserToDeleteRows = false;
            this.KoenigJUGGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KoenigJUGGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KoenigJUGGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PositionJUG,
            this.FullnameJUG,
            this.DatumJUG,
            this.TeilerJUG,
            this.TypJUG});
            this.KoenigJUGGridView.Location = new System.Drawing.Point(3, 16);
            this.KoenigJUGGridView.Name = "KoenigJUGGridView";
            this.KoenigJUGGridView.ReadOnly = true;
            this.KoenigJUGGridView.RowHeadersVisible = false;
            this.KoenigJUGGridView.Size = new System.Drawing.Size(565, 200);
            this.KoenigJUGGridView.TabIndex = 3;
            this.KoenigJUGGridView.Resize += new System.EventHandler(this.KoenigSKGridView_Resize);
            // 
            // PositionJUG
            // 
            this.PositionJUG.HeaderText = "Pos.";
            this.PositionJUG.Name = "PositionJUG";
            this.PositionJUG.ReadOnly = true;
            this.PositionJUG.Width = 30;
            // 
            // FullnameJUG
            // 
            this.FullnameJUG.HeaderText = "Name";
            this.FullnameJUG.Name = "FullnameJUG";
            this.FullnameJUG.ReadOnly = true;
            // 
            // DatumJUG
            // 
            dataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DatumJUG.DefaultCellStyle = dataGridViewCellStyle70;
            this.DatumJUG.HeaderText = "Datum";
            this.DatumJUG.Name = "DatumJUG";
            this.DatumJUG.ReadOnly = true;
            // 
            // TeilerJUG
            // 
            dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TeilerJUG.DefaultCellStyle = dataGridViewCellStyle71;
            this.TeilerJUG.HeaderText = "Teiler";
            this.TeilerJUG.Name = "TeilerJUG";
            this.TeilerJUG.ReadOnly = true;
            this.TeilerJUG.Width = 40;
            // 
            // TypJUG
            // 
            dataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TypJUG.DefaultCellStyle = dataGridViewCellStyle72;
            this.TypJUG.HeaderText = "Typ";
            this.TypJUG.Name = "TypJUG";
            this.TypJUG.ReadOnly = true;
            this.TypJUG.Width = 30;
            // 
            // TagesAuswertung
            // 
            this.TagesAuswertung.Controls.Add(this.btnKassenbericht);
            this.TagesAuswertung.Controls.Add(this.button4);
            this.TagesAuswertung.Controls.Add(this.btnTagesAuswertungListeDrucken);
            this.TagesAuswertung.Controls.Add(this.btnTagesAuswertungDrucken);
            this.TagesAuswertung.Controls.Add(this.dateTimePicker1);
            this.TagesAuswertung.Controls.Add(this.Schiessabend);
            this.TagesAuswertung.Location = new System.Drawing.Point(4, 22);
            this.TagesAuswertung.Name = "TagesAuswertung";
            this.TagesAuswertung.Padding = new System.Windows.Forms.Padding(3);
            this.TagesAuswertung.Size = new System.Drawing.Size(952, 419);
            this.TagesAuswertung.TabIndex = 3;
            this.TagesAuswertung.Text = "Tagesauswertung";
            this.TagesAuswertung.UseVisualStyleBackColor = true;
            // 
            // btnKassenbericht
            // 
            this.btnKassenbericht.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKassenbericht.Location = new System.Drawing.Point(628, 3);
            this.btnKassenbericht.Name = "btnKassenbericht";
            this.btnKassenbericht.Size = new System.Drawing.Size(140, 23);
            this.btnKassenbericht.TabIndex = 8;
            this.btnKassenbericht.Text = "Kassenbericht drucken...";
            this.btnKassenbericht.UseVisualStyleBackColor = true;
            this.btnKassenbericht.Click += new System.EventHandler(this.btnKassenbericht_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(213, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 20);
            this.button4.TabIndex = 7;
            this.button4.Text = "Aktualisieren";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnTagesAuswertungListeDrucken
            // 
            this.btnTagesAuswertungListeDrucken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTagesAuswertungListeDrucken.Location = new System.Drawing.Point(774, 3);
            this.btnTagesAuswertungListeDrucken.Name = "btnTagesAuswertungListeDrucken";
            this.btnTagesAuswertungListeDrucken.Size = new System.Drawing.Size(91, 23);
            this.btnTagesAuswertungListeDrucken.TabIndex = 6;
            this.btnTagesAuswertungListeDrucken.Text = "&Liste drucken...";
            this.btnTagesAuswertungListeDrucken.UseVisualStyleBackColor = true;
            this.btnTagesAuswertungListeDrucken.Click += new System.EventHandler(this.btnTagesAuswertungListeDrucken_Click);
            // 
            // btnTagesAuswertungDrucken
            // 
            this.btnTagesAuswertungDrucken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTagesAuswertungDrucken.Location = new System.Drawing.Point(871, 3);
            this.btnTagesAuswertungDrucken.Name = "btnTagesAuswertungDrucken";
            this.btnTagesAuswertungDrucken.Size = new System.Drawing.Size(75, 23);
            this.btnTagesAuswertungDrucken.TabIndex = 5;
            this.btnTagesAuswertungDrucken.Text = "&Drucken...";
            this.btnTagesAuswertungDrucken.UseVisualStyleBackColor = true;
            this.btnTagesAuswertungDrucken.Click += new System.EventHandler(this.btnTagesAuswertungDrucken_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Schiessabend
            // 
            this.Schiessabend.AllowUserToAddRows = false;
            this.Schiessabend.AllowUserToDeleteRows = false;
            this.Schiessabend.AllowUserToResizeColumns = false;
            this.Schiessabend.AllowUserToResizeRows = false;
            this.Schiessabend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Schiessabend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Schiessabend.Location = new System.Drawing.Point(6, 32);
            this.Schiessabend.Name = "Schiessabend";
            this.Schiessabend.Size = new System.Drawing.Size(940, 381);
            this.Schiessabend.TabIndex = 3;
            this.Schiessabend.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Schiessabend_CellEndEdit);
            // 
            // AuswertungTab
            // 
            this.AuswertungTab.BackColor = System.Drawing.SystemColors.Control;
            this.AuswertungTab.Controls.Add(this.tabControl2);
            this.AuswertungTab.Controls.Add(this.groupBox2);
            this.AuswertungTab.Location = new System.Drawing.Point(4, 22);
            this.AuswertungTab.Name = "AuswertungTab";
            this.AuswertungTab.Padding = new System.Windows.Forms.Padding(3);
            this.AuswertungTab.Size = new System.Drawing.Size(952, 419);
            this.AuswertungTab.TabIndex = 1;
            this.AuswertungTab.Text = "Auswertung";
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(464, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(485, 387);
            this.tabControl2.TabIndex = 27;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.tableLayoutPanel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(477, 361);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Luftgewehr 10 m";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.AuswertungLG30, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.AuswertungLG20, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AuswertungLG20_15, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AuswertungLG30_15, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.AuswertungLG40, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.AuswertungLG40_15, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.74648F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.253521F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(471, 355);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // AuswertungLG30
            // 
            this.AuswertungLG30.BackColor = System.Drawing.SystemColors.Control;
            this.AuswertungLG30.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuswertungLG30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuswertungLG30.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuswertungLG30.Location = new System.Drawing.Point(159, 3);
            this.AuswertungLG30.Multiline = true;
            this.AuswertungLG30.Name = "AuswertungLG30";
            this.AuswertungLG30.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuswertungLG30.Size = new System.Drawing.Size(72, 341);
            this.AuswertungLG30.TabIndex = 27;
            this.AuswertungLG30.Text = "Luftgewehr 10 m\r\n---------------\r\n1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n";
            // 
            // AuswertungLG20
            // 
            this.AuswertungLG20.BackColor = System.Drawing.SystemColors.Control;
            this.AuswertungLG20.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuswertungLG20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuswertungLG20.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuswertungLG20.Location = new System.Drawing.Point(3, 3);
            this.AuswertungLG20.Multiline = true;
            this.AuswertungLG20.Name = "AuswertungLG20";
            this.AuswertungLG20.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuswertungLG20.Size = new System.Drawing.Size(72, 341);
            this.AuswertungLG20.TabIndex = 26;
            this.AuswertungLG20.Text = "Luftgewehr 10 m\r\n---------------\r\n1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n";
            // 
            // AuswertungLG20_15
            // 
            this.AuswertungLG20_15.BackColor = System.Drawing.SystemColors.Control;
            this.AuswertungLG20_15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuswertungLG20_15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuswertungLG20_15.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuswertungLG20_15.Location = new System.Drawing.Point(81, 3);
            this.AuswertungLG20_15.Multiline = true;
            this.AuswertungLG20_15.Name = "AuswertungLG20_15";
            this.AuswertungLG20_15.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuswertungLG20_15.Size = new System.Drawing.Size(72, 341);
            this.AuswertungLG20_15.TabIndex = 26;
            this.AuswertungLG20_15.Text = "Luftgewehr 10 m\r\n---------------\r\n1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n";
            this.AuswertungLG20_15.TextChanged += new System.EventHandler(this.AuswertungLG30_TextChanged);
            // 
            // AuswertungLG30_15
            // 
            this.AuswertungLG30_15.BackColor = System.Drawing.SystemColors.Control;
            this.AuswertungLG30_15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuswertungLG30_15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuswertungLG30_15.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuswertungLG30_15.Location = new System.Drawing.Point(237, 3);
            this.AuswertungLG30_15.Multiline = true;
            this.AuswertungLG30_15.Name = "AuswertungLG30_15";
            this.AuswertungLG30_15.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuswertungLG30_15.Size = new System.Drawing.Size(72, 341);
            this.AuswertungLG30_15.TabIndex = 31;
            this.AuswertungLG30_15.Text = "Luftgewehr 10 m\r\n---------------\r\n1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n";
            // 
            // AuswertungLG40
            // 
            this.AuswertungLG40.BackColor = System.Drawing.SystemColors.Control;
            this.AuswertungLG40.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuswertungLG40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuswertungLG40.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuswertungLG40.Location = new System.Drawing.Point(315, 3);
            this.AuswertungLG40.Multiline = true;
            this.AuswertungLG40.Name = "AuswertungLG40";
            this.AuswertungLG40.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuswertungLG40.Size = new System.Drawing.Size(72, 341);
            this.AuswertungLG40.TabIndex = 29;
            this.AuswertungLG40.Text = "Luftgewehr 10 m\r\n---------------\r\n1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n";
            // 
            // AuswertungLG40_15
            // 
            this.AuswertungLG40_15.BackColor = System.Drawing.SystemColors.Control;
            this.AuswertungLG40_15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuswertungLG40_15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuswertungLG40_15.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuswertungLG40_15.Location = new System.Drawing.Point(393, 3);
            this.AuswertungLG40_15.Multiline = true;
            this.AuswertungLG40_15.Name = "AuswertungLG40_15";
            this.AuswertungLG40_15.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuswertungLG40_15.Size = new System.Drawing.Size(75, 341);
            this.AuswertungLG40_15.TabIndex = 28;
            this.AuswertungLG40_15.Text = "Luftgewehr 10 m\r\n---------------\r\n1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.tableLayoutPanel2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(477, 361);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Luftgewehr 10 m Auflage";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.7F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.AuswertungLG30A, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.AuswertungLG30A_15, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.AuswertungLG40A, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.AuswertungLG40A_15, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.AuswertungLG20A_15, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.AuswertungLG20A, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.78394F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.216067F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(477, 361);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // AuswertungLG30A
            // 
            this.AuswertungLG30A.BackColor = System.Drawing.SystemColors.Control;
            this.AuswertungLG30A.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuswertungLG30A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuswertungLG30A.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuswertungLG30A.Location = new System.Drawing.Point(161, 3);
            this.AuswertungLG30A.Multiline = true;
            this.AuswertungLG30A.Name = "AuswertungLG30A";
            this.AuswertungLG30A.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuswertungLG30A.Size = new System.Drawing.Size(73, 347);
            this.AuswertungLG30A.TabIndex = 27;
            this.AuswertungLG30A.Text = "Luftgewehr 10 m\r\n---------------\r\n1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n";
            // 
            // AuswertungLG30A_15
            // 
            this.AuswertungLG30A_15.BackColor = System.Drawing.SystemColors.Control;
            this.AuswertungLG30A_15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuswertungLG30A_15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuswertungLG30A_15.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuswertungLG30A_15.Location = new System.Drawing.Point(240, 3);
            this.AuswertungLG30A_15.Multiline = true;
            this.AuswertungLG30A_15.Name = "AuswertungLG30A_15";
            this.AuswertungLG30A_15.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuswertungLG30A_15.Size = new System.Drawing.Size(73, 347);
            this.AuswertungLG30A_15.TabIndex = 31;
            this.AuswertungLG30A_15.Text = "Luftgewehr 10 m\r\n---------------\r\n1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n";
            // 
            // AuswertungLG40A
            // 
            this.AuswertungLG40A.BackColor = System.Drawing.SystemColors.Control;
            this.AuswertungLG40A.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuswertungLG40A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuswertungLG40A.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuswertungLG40A.Location = new System.Drawing.Point(319, 3);
            this.AuswertungLG40A.Multiline = true;
            this.AuswertungLG40A.Name = "AuswertungLG40A";
            this.AuswertungLG40A.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuswertungLG40A.Size = new System.Drawing.Size(73, 347);
            this.AuswertungLG40A.TabIndex = 29;
            this.AuswertungLG40A.Text = "Luftgewehr 10 m\r\n---------------\r\n1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n";
            // 
            // AuswertungLG40A_15
            // 
            this.AuswertungLG40A_15.BackColor = System.Drawing.SystemColors.Control;
            this.AuswertungLG40A_15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuswertungLG40A_15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuswertungLG40A_15.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuswertungLG40A_15.Location = new System.Drawing.Point(398, 3);
            this.AuswertungLG40A_15.Multiline = true;
            this.AuswertungLG40A_15.Name = "AuswertungLG40A_15";
            this.AuswertungLG40A_15.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuswertungLG40A_15.Size = new System.Drawing.Size(76, 347);
            this.AuswertungLG40A_15.TabIndex = 28;
            this.AuswertungLG40A_15.Text = "Luftgewehr 10 m\r\n---------------\r\n1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n";
            // 
            // AuswertungLG20A_15
            // 
            this.AuswertungLG20A_15.BackColor = System.Drawing.SystemColors.Control;
            this.AuswertungLG20A_15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuswertungLG20A_15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuswertungLG20A_15.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuswertungLG20A_15.Location = new System.Drawing.Point(82, 3);
            this.AuswertungLG20A_15.Multiline = true;
            this.AuswertungLG20A_15.Name = "AuswertungLG20A_15";
            this.AuswertungLG20A_15.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuswertungLG20A_15.Size = new System.Drawing.Size(73, 347);
            this.AuswertungLG20A_15.TabIndex = 26;
            this.AuswertungLG20A_15.Text = "Luftgewehr 10 m\r\n---------------\r\n1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n";
            // 
            // AuswertungLG20A
            // 
            this.AuswertungLG20A.BackColor = System.Drawing.SystemColors.Control;
            this.AuswertungLG20A.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuswertungLG20A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuswertungLG20A.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuswertungLG20A.Location = new System.Drawing.Point(3, 3);
            this.AuswertungLG20A.Multiline = true;
            this.AuswertungLG20A.Name = "AuswertungLG20A";
            this.AuswertungLG20A.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuswertungLG20A.Size = new System.Drawing.Size(73, 347);
            this.AuswertungLG20A.TabIndex = 26;
            this.AuswertungLG20A.Text = "Luftgewehr 10 m\r\n---------------\r\n1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(477, 361);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Luftpistole 10 m";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.7F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.AuswertungLP30, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.AuswertungLP20, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.AuswertungLP20_15, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.AuswertungLP30_15, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.AuswertungLP40, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.AuswertungLP40_15, 5, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.63866F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.361345F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(476, 357);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // AuswertungLP30
            // 
            this.AuswertungLP30.BackColor = System.Drawing.SystemColors.Control;
            this.AuswertungLP30.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuswertungLP30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuswertungLP30.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuswertungLP30.Location = new System.Drawing.Point(161, 3);
            this.AuswertungLP30.Multiline = true;
            this.AuswertungLP30.Name = "AuswertungLP30";
            this.AuswertungLP30.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuswertungLP30.Size = new System.Drawing.Size(73, 339);
            this.AuswertungLP30.TabIndex = 27;
            this.AuswertungLP30.Text = "Luftgewehr 10 m\r\n---------------\r\n1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n";
            // 
            // AuswertungLP20
            // 
            this.AuswertungLP20.BackColor = System.Drawing.SystemColors.Control;
            this.AuswertungLP20.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuswertungLP20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuswertungLP20.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuswertungLP20.Location = new System.Drawing.Point(3, 3);
            this.AuswertungLP20.Multiline = true;
            this.AuswertungLP20.Name = "AuswertungLP20";
            this.AuswertungLP20.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuswertungLP20.Size = new System.Drawing.Size(73, 339);
            this.AuswertungLP20.TabIndex = 26;
            this.AuswertungLP20.Text = "Luftgewehr 10 m\r\n---------------\r\n1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n";
            // 
            // AuswertungLP20_15
            // 
            this.AuswertungLP20_15.BackColor = System.Drawing.SystemColors.Control;
            this.AuswertungLP20_15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuswertungLP20_15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuswertungLP20_15.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuswertungLP20_15.Location = new System.Drawing.Point(82, 3);
            this.AuswertungLP20_15.Multiline = true;
            this.AuswertungLP20_15.Name = "AuswertungLP20_15";
            this.AuswertungLP20_15.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuswertungLP20_15.Size = new System.Drawing.Size(73, 339);
            this.AuswertungLP20_15.TabIndex = 26;
            this.AuswertungLP20_15.Text = "Luftgewehr 10 m\r\n---------------\r\n1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n";
            // 
            // AuswertungLP30_15
            // 
            this.AuswertungLP30_15.BackColor = System.Drawing.SystemColors.Control;
            this.AuswertungLP30_15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuswertungLP30_15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuswertungLP30_15.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuswertungLP30_15.Location = new System.Drawing.Point(240, 3);
            this.AuswertungLP30_15.Multiline = true;
            this.AuswertungLP30_15.Name = "AuswertungLP30_15";
            this.AuswertungLP30_15.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuswertungLP30_15.Size = new System.Drawing.Size(73, 339);
            this.AuswertungLP30_15.TabIndex = 31;
            this.AuswertungLP30_15.Text = "Luftgewehr 10 m\r\n---------------\r\n1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n";
            // 
            // AuswertungLP40
            // 
            this.AuswertungLP40.BackColor = System.Drawing.SystemColors.Control;
            this.AuswertungLP40.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuswertungLP40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuswertungLP40.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuswertungLP40.Location = new System.Drawing.Point(319, 3);
            this.AuswertungLP40.Multiline = true;
            this.AuswertungLP40.Name = "AuswertungLP40";
            this.AuswertungLP40.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuswertungLP40.Size = new System.Drawing.Size(73, 339);
            this.AuswertungLP40.TabIndex = 29;
            this.AuswertungLP40.Text = "Luftgewehr 10 m\r\n---------------\r\n1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n";
            // 
            // AuswertungLP40_15
            // 
            this.AuswertungLP40_15.BackColor = System.Drawing.SystemColors.Control;
            this.AuswertungLP40_15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuswertungLP40_15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuswertungLP40_15.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuswertungLP40_15.Location = new System.Drawing.Point(398, 3);
            this.AuswertungLP40_15.Multiline = true;
            this.AuswertungLP40_15.Name = "AuswertungLP40_15";
            this.AuswertungLP40_15.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuswertungLP40_15.Size = new System.Drawing.Size(75, 339);
            this.AuswertungLP40_15.TabIndex = 28;
            this.AuswertungLP40_15.Text = "Luftgewehr 10 m\r\n---------------\r\n1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.SchuetzeComboBox);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 155);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schütze";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Schütze:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nummer:";
            // 
            // SchuetzeComboBox
            // 
            this.SchuetzeComboBox.CausesValidation = false;
            this.SchuetzeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuetzenBindingSource, "fullname", true));
            this.SchuetzeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.schuetzenBindingSource, "id", true));
            this.SchuetzeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SchuetzeComboBox.Location = new System.Drawing.Point(63, 19);
            this.SchuetzeComboBox.Name = "SchuetzeComboBox";
            this.SchuetzeComboBox.Size = new System.Drawing.Size(383, 21);
            this.SchuetzeComboBox.TabIndex = 22;
            this.SchuetzeComboBox.Visible = false;
            this.SchuetzeComboBox.SelectedIndexChanged += new System.EventHandler(this.fullNameComboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuetzenListeBindingSource, "id", true));
            this.textBox1.Location = new System.Drawing.Point(63, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(31, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuetzenListeBindingSource, "verein", true));
            this.textBox2.Location = new System.Drawing.Point(63, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(305, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Verein:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuetzenListeBindingSource, "name", true));
            this.textBox3.Location = new System.Drawing.Point(63, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuetzenListeBindingSource, "email", true));
            this.textBox4.Location = new System.Drawing.Point(63, 98);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(305, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vorname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "E-Mail:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuetzenListeBindingSource, "vorname", true));
            this.textBox5.Location = new System.Drawing.Point(247, 72);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 6;
            // 
            // SchiessbuchTab
            // 
            this.SchiessbuchTab.AutoScroll = true;
            this.SchiessbuchTab.BackColor = System.Drawing.SystemColors.Control;
            this.SchiessbuchTab.Controls.Add(vereinLabel1);
            this.SchiessbuchTab.Controls.Add(this.groupBox1);
            this.SchiessbuchTab.Controls.Add(this.checkBox1);
            this.SchiessbuchTab.Controls.Add(this.SchiessabendPicker);
            this.SchiessbuchTab.Controls.Add(this.pictureBox1);
            this.SchiessbuchTab.Controls.Add(this.schiessbuchDataGridView);
            this.SchiessbuchTab.Controls.Add(this.zielscheibeLabel);
            this.SchiessbuchTab.Controls.Add(this.zielscheibeTextBox);
            this.SchiessbuchTab.Controls.Add(this.trefferDataGridView);
            this.SchiessbuchTab.Location = new System.Drawing.Point(4, 22);
            this.SchiessbuchTab.Name = "SchiessbuchTab";
            this.SchiessbuchTab.Padding = new System.Windows.Forms.Padding(3);
            this.SchiessbuchTab.Size = new System.Drawing.Size(952, 419);
            this.SchiessbuchTab.TabIndex = 0;
            this.SchiessbuchTab.Text = "Schießbuch";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KlasseName);
            this.groupBox1.Controls.Add(this.geburtsdatumTextBox);
            this.groupBox1.Controls.Add(this.geschlechtTextBox);
            this.groupBox1.Controls.Add(this.lblWanderpokalschiessen);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.vereinComboBox);
            this.groupBox1.Controls.Add(this.DoUpdates);
            this.groupBox1.Controls.Add(this.fullnameLabel);
            this.groupBox1.Controls.Add(this.idLabel);
            this.groupBox1.Controls.Add(this.fullnameComboBox);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.vereinTextBox);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.vereinLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.vornameLabel);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.vornameTextBox);
            this.groupBox1.Controls.Add(this.GeburtstagDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 155);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schütze";
            // 
            // KlasseName
            // 
            this.KlasseName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuetzenListeBindingSource, "Jahrgangsklasse", true));
            this.KlasseName.Location = new System.Drawing.Point(346, 20);
            this.KlasseName.Name = "KlasseName";
            this.KlasseName.ReadOnly = true;
            this.KlasseName.Size = new System.Drawing.Size(100, 20);
            this.KlasseName.TabIndex = 33;
            // 
            // geburtsdatumTextBox
            // 
            this.geburtsdatumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuetzenListeBindingSource, "geburtsdatum", true));
            this.geburtsdatumTextBox.Location = new System.Drawing.Point(125, 46);
            this.geburtsdatumTextBox.Name = "geburtsdatumTextBox";
            this.geburtsdatumTextBox.ReadOnly = true;
            this.geburtsdatumTextBox.Size = new System.Drawing.Size(83, 20);
            this.geburtsdatumTextBox.TabIndex = 31;
            // 
            // geschlechtTextBox
            // 
            this.geschlechtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuetzenListeBindingSource, "geschlecht", true));
            this.geschlechtTextBox.Location = new System.Drawing.Point(100, 46);
            this.geschlechtTextBox.Name = "geschlechtTextBox";
            this.geschlechtTextBox.ReadOnly = true;
            this.geschlechtTextBox.Size = new System.Drawing.Size(19, 20);
            this.geschlechtTextBox.TabIndex = 30;
            this.geschlechtTextBox.TextChanged += new System.EventHandler(this.geschlechtTextBox_TextChanged);
            // 
            // lblWanderpokalschiessen
            // 
            this.lblWanderpokalschiessen.AutoSize = true;
            this.lblWanderpokalschiessen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWanderpokalschiessen.ForeColor = System.Drawing.Color.Red;
            this.lblWanderpokalschiessen.Location = new System.Drawing.Point(214, 49);
            this.lblWanderpokalschiessen.Name = "lblWanderpokalschiessen";
            this.lblWanderpokalschiessen.Size = new System.Drawing.Size(171, 13);
            this.lblWanderpokalschiessen.TabIndex = 29;
            this.lblWanderpokalschiessen.Text = "heute Jahrespokalschiessen!";
            this.lblWanderpokalschiessen.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 48);
            this.button1.TabIndex = 24;
            this.button1.Text = "Manuell nachtragen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vereinComboBox
            // 
            this.vereinComboBox.DataSource = this.vereineBindingSource;
            this.vereinComboBox.DisplayMember = "verein";
            this.vereinComboBox.FormattingEnabled = true;
            this.vereinComboBox.Location = new System.Drawing.Point(63, 124);
            this.vereinComboBox.Name = "vereinComboBox";
            this.vereinComboBox.Size = new System.Drawing.Size(305, 21);
            this.vereinComboBox.TabIndex = 28;
            this.vereinComboBox.ValueMember = "verein";
            this.vereinComboBox.Visible = false;
            this.vereinComboBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // vereineBindingSource
            // 
            this.vereineBindingSource.DataMember = "Vereine";
            this.vereineBindingSource.DataSource = this.siusclubDataSet1;
            // 
            // siusclubDataSet1
            // 
            this.siusclubDataSet1.DataSetName = "siusclubDataSet";
            this.siusclubDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DoUpdates
            // 
            this.DoUpdates.Appearance = System.Windows.Forms.Appearance.Button;
            this.DoUpdates.Image = global::schiessbuch.Properties.Resources.refresh40;
            this.DoUpdates.Location = new System.Drawing.Point(398, 49);
            this.DoUpdates.Name = "DoUpdates";
            this.DoUpdates.Size = new System.Drawing.Size(48, 48);
            this.DoUpdates.TabIndex = 23;
            this.DoUpdates.UseVisualStyleBackColor = true;
            this.DoUpdates.CheckedChanged += new System.EventHandler(this.DoUpdates_CheckedChanged);
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Location = new System.Drawing.Point(6, 22);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(49, 13);
            this.fullnameLabel.TabIndex = 21;
            this.fullnameLabel.Text = "Schütze:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(6, 49);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(49, 13);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "Nummer:";
            // 
            // fullnameComboBox
            // 
            this.fullnameComboBox.CausesValidation = false;
            this.fullnameComboBox.DataSource = this.schuetzenListeBindingSource;
            this.fullnameComboBox.DisplayMember = "fullname";
            this.fullnameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fullnameComboBox.Location = new System.Drawing.Point(63, 19);
            this.fullnameComboBox.Name = "fullnameComboBox";
            this.fullnameComboBox.Size = new System.Drawing.Size(277, 21);
            this.fullnameComboBox.TabIndex = 22;
            this.fullnameComboBox.ValueMember = "id";
            this.fullnameComboBox.SelectedIndexChanged += new System.EventHandler(this.fullnameComboBox_SelectedIndexChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuetzenListeBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(63, 46);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(31, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // vereinTextBox
            // 
            this.vereinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuetzenListeBindingSource, "verein", true));
            this.vereinTextBox.Location = new System.Drawing.Point(63, 124);
            this.vereinTextBox.Name = "vereinTextBox";
            this.vereinTextBox.ReadOnly = true;
            this.vereinTextBox.Size = new System.Drawing.Size(305, 20);
            this.vereinTextBox.TabIndex = 10;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 75);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // vereinLabel
            // 
            this.vereinLabel.AutoSize = true;
            this.vereinLabel.Location = new System.Drawing.Point(6, 127);
            this.vereinLabel.Name = "vereinLabel";
            this.vereinLabel.Size = new System.Drawing.Size(40, 13);
            this.vereinLabel.TabIndex = 9;
            this.vereinLabel.Text = "Verein:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuetzenListeBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(63, 72);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuetzenListeBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(63, 98);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(305, 20);
            this.emailTextBox.TabIndex = 8;
            this.emailTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // vornameLabel
            // 
            this.vornameLabel.AutoSize = true;
            this.vornameLabel.Location = new System.Drawing.Point(190, 75);
            this.vornameLabel.Name = "vornameLabel";
            this.vornameLabel.Size = new System.Drawing.Size(52, 13);
            this.vornameLabel.TabIndex = 5;
            this.vornameLabel.Text = "Vorname:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(6, 101);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(39, 13);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "E-Mail:";
            // 
            // vornameTextBox
            // 
            this.vornameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuetzenListeBindingSource, "vorname", true));
            this.vornameTextBox.Location = new System.Drawing.Point(247, 72);
            this.vornameTextBox.Name = "vornameTextBox";
            this.vornameTextBox.ReadOnly = true;
            this.vornameTextBox.Size = new System.Drawing.Size(121, 20);
            this.vornameTextBox.TabIndex = 6;
            this.vornameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // GeburtstagDateTimePicker
            // 
            this.GeburtstagDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.GeburtstagDateTimePicker.Location = new System.Drawing.Point(125, 46);
            this.GeburtstagDateTimePicker.Name = "GeburtstagDateTimePicker";
            this.GeburtstagDateTimePicker.Size = new System.Drawing.Size(83, 20);
            this.GeburtstagDateTimePicker.TabIndex = 32;
            this.GeburtstagDateTimePicker.Visible = false;
            this.GeburtstagDateTimePicker.ValueChanged += new System.EventHandler(this.GeburtstagDateTimePicker_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 167);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Filter";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SchiessabendPicker
            // 
            this.SchiessabendPicker.Enabled = false;
            this.SchiessabendPicker.Location = new System.Drawing.Point(60, 164);
            this.SchiessabendPicker.Name = "SchiessabendPicker";
            this.SchiessabendPicker.Size = new System.Drawing.Size(184, 20);
            this.SchiessabendPicker.TabIndex = 24;
            this.SchiessabendPicker.ValueChanged += new System.EventHandler(this.SchiessabendPicker_ValueChanged);
            this.SchiessabendPicker.EnabledChanged += new System.EventHandler(this.SchiessabendPicker_EnabledChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::schiessbuch.Properties.Resources.Luftpistole;
            this.pictureBox1.Location = new System.Drawing.Point(737, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 381);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // schiessbuchDataGridView
            // 
            this.schiessbuchDataGridView.AllowUserToAddRows = false;
            this.schiessbuchDataGridView.AllowUserToDeleteRows = false;
            this.schiessbuchDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.schiessbuchDataGridView.AutoGenerateColumns = false;
            this.schiessbuchDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.schiessbuchDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle73.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle73.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle73.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle73.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle73.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle73.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle73.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.schiessbuchDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle73;
            this.schiessbuchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schiessbuchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDisziplin,
            this.dataGridViewTextBoxColumn4,
            this.session,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.dt});
            this.schiessbuchDataGridView.ContextMenuStrip = this.SchiessbuchContexMenu;
            this.schiessbuchDataGridView.DataSource = this.schuetzenlisteschiessbuchBindingSource;
            dataGridViewCellStyle78.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle78.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle78.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle78.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle78.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle78.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle78.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.schiessbuchDataGridView.DefaultCellStyle = dataGridViewCellStyle78;
            this.schiessbuchDataGridView.Location = new System.Drawing.Point(6, 190);
            this.schiessbuchDataGridView.MultiSelect = false;
            this.schiessbuchDataGridView.Name = "schiessbuchDataGridView";
            this.schiessbuchDataGridView.ReadOnly = true;
            dataGridViewCellStyle79.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle79.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle79.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle79.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle79.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle79.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle79.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.schiessbuchDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle79;
            this.schiessbuchDataGridView.RowHeadersWidth = 10;
            this.schiessbuchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.schiessbuchDataGridView.ShowEditingIcon = false;
            this.schiessbuchDataGridView.ShowRowErrors = false;
            this.schiessbuchDataGridView.Size = new System.Drawing.Size(452, 226);
            this.schiessbuchDataGridView.TabIndex = 23;
            this.schiessbuchDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.schiessbuchDataGridView_CellMouseEnter);
            this.schiessbuchDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.schiessbuchDataGridView_DataError);
            this.schiessbuchDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.schiessbuchDataGridView_RowEnter);
            this.schiessbuchDataGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.schiessbuchDataGridView_RowLeave);
            this.schiessbuchDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.schiessbuchDataGridView_UserDeletingRow);
            // 
            // colDisziplin
            // 
            this.colDisziplin.DataPropertyName = "disziplin";
            this.colDisziplin.HeaderText = "Disziplin";
            this.colDisziplin.Name = "colDisziplin";
            this.colDisziplin.ReadOnly = true;
            this.colDisziplin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDisziplin.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "stand";
            dataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle74;
            this.dataGridViewTextBoxColumn4.HeaderText = "Stand";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // session
            // 
            this.session.DataPropertyName = "session";
            this.session.HeaderText = "session";
            this.session.Name = "session";
            this.session.ReadOnly = true;
            this.session.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ergebnis";
            dataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle75;
            this.dataGridViewTextBoxColumn3.HeaderText = "Ergebnis";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn5.HeaderText = "Status";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "dt";
            dataGridViewCellStyle76.Format = "d";
            dataGridViewCellStyle76.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle76;
            this.dataGridViewTextBoxColumn8.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dt
            // 
            this.dt.DataPropertyName = "dt";
            dataGridViewCellStyle77.Format = "T";
            dataGridViewCellStyle77.NullValue = null;
            this.dt.DefaultCellStyle = dataGridViewCellStyle77;
            this.dt.HeaderText = "Uhrzeit";
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            this.dt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dt.Width = 70;
            // 
            // zielscheibeLabel
            // 
            this.zielscheibeLabel.AutoSize = true;
            this.zielscheibeLabel.Location = new System.Drawing.Point(737, 9);
            this.zielscheibeLabel.Name = "zielscheibeLabel";
            this.zielscheibeLabel.Size = new System.Drawing.Size(64, 13);
            this.zielscheibeLabel.TabIndex = 26;
            this.zielscheibeLabel.Text = "Zielscheibe:";
            // 
            // zielscheibeTextBox
            // 
            this.zielscheibeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zielscheibeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schiessbuchtrefferBindingSource, "zielscheibe", true));
            this.zielscheibeTextBox.Location = new System.Drawing.Point(805, 6);
            this.zielscheibeTextBox.Name = "zielscheibeTextBox";
            this.zielscheibeTextBox.ReadOnly = true;
            this.zielscheibeTextBox.Size = new System.Drawing.Size(141, 20);
            this.zielscheibeTextBox.TabIndex = 27;
            // 
            // trefferDataGridView
            // 
            this.trefferDataGridView.AllowUserToAddRows = false;
            this.trefferDataGridView.AllowUserToDeleteRows = false;
            this.trefferDataGridView.AllowUserToResizeRows = false;
            this.trefferDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trefferDataGridView.AutoGenerateColumns = false;
            this.trefferDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.trefferDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.trefferDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.trefferDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trefferDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.schritt,
            this.dataGridViewTextBoxColumn29,
            this.schussnummer,
            this.ring,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.xinmm,
            this.yinmm,
            this.xrahmeninmm,
            this.yrahmeninmm,
            this.schuetze,
            this.disziplin,
            this.zielscheibe,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.id,
            this.SchrittText});
            this.trefferDataGridView.DataSource = this.schiessbuchtrefferBindingSource;
            dataGridViewCellStyle84.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle84.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle84.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle84.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle84.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle84.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle84.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.trefferDataGridView.DefaultCellStyle = dataGridViewCellStyle84;
            this.trefferDataGridView.Location = new System.Drawing.Point(464, 6);
            this.trefferDataGridView.Name = "trefferDataGridView";
            this.trefferDataGridView.ReadOnly = true;
            dataGridViewCellStyle85.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle85.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle85.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle85.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle85.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle85.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle85.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.trefferDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle85;
            this.trefferDataGridView.RowHeadersWidth = 10;
            this.trefferDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.trefferDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.trefferDataGridView.Size = new System.Drawing.Size(267, 407);
            this.trefferDataGridView.TabIndex = 25;
            this.trefferDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.trefferDataGridView_CellFormatting);
            this.trefferDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.trefferDataGridView_DataError);
            this.trefferDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.trefferDataGridView_RowsRemoved);
            this.trefferDataGridView.SelectionChanged += new System.EventHandler(this.trefferDataGridView_SelectionChanged);
            // 
            // schritt
            // 
            this.schritt.DataPropertyName = "schritt";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.schritt.DefaultCellStyle = dataGridViewCellStyle34;
            this.schritt.HeaderText = "Schritt";
            this.schritt.Name = "schritt";
            this.schritt.ReadOnly = true;
            this.schritt.Width = 40;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "serie";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn29.DefaultCellStyle = dataGridViewCellStyle35;
            this.dataGridViewTextBoxColumn29.HeaderText = "Serie";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.Width = 40;
            // 
            // schussnummer
            // 
            this.schussnummer.DataPropertyName = "schussnummer";
            dataGridViewCellStyle80.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.schussnummer.DefaultCellStyle = dataGridViewCellStyle80;
            this.schussnummer.HeaderText = "S";
            this.schussnummer.Name = "schussnummer";
            this.schussnummer.ReadOnly = true;
            this.schussnummer.Width = 30;
            // 
            // ring
            // 
            this.ring.DataPropertyName = "ring";
            dataGridViewCellStyle81.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ring.DefaultCellStyle = dataGridViewCellStyle81;
            this.ring.HeaderText = "Ring";
            this.ring.Name = "ring";
            this.ring.ReadOnly = true;
            this.ring.Width = 40;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "zentrum";
            this.dataGridViewTextBoxColumn6.HeaderText = "zentrum";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "zehntel";
            dataGridViewCellStyle82.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle82;
            this.dataGridViewTextBoxColumn7.HeaderText = "Zehntel";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "teiler";
            dataGridViewCellStyle83.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle83;
            this.dataGridViewTextBoxColumn9.HeaderText = "Teiler";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 40;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "anzeige";
            this.dataGridViewTextBoxColumn10.HeaderText = "anzeige";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "radiusziel";
            this.dataGridViewTextBoxColumn11.HeaderText = "radiusziel";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "winkelmassziel";
            this.dataGridViewTextBoxColumn12.HeaderText = "winkelmassziel";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "radiusrahmen";
            this.dataGridViewTextBoxColumn13.HeaderText = "radiusrahmen";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "winkelmassrahmen";
            this.dataGridViewTextBoxColumn14.HeaderText = "winkelmassrahmen";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "start";
            this.dataGridViewTextBoxColumn16.HeaderText = "start";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "zeitstempel";
            this.dataGridViewTextBoxColumn17.HeaderText = "zeitstempel";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "stand";
            this.dataGridViewTextBoxColumn18.HeaderText = "stand";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // xinmm
            // 
            this.xinmm.DataPropertyName = "xinmm";
            this.xinmm.HeaderText = "xinmm";
            this.xinmm.Name = "xinmm";
            this.xinmm.ReadOnly = true;
            this.xinmm.Visible = false;
            // 
            // yinmm
            // 
            this.yinmm.DataPropertyName = "yinmm";
            this.yinmm.HeaderText = "yinmm";
            this.yinmm.Name = "yinmm";
            this.yinmm.ReadOnly = true;
            this.yinmm.Visible = false;
            // 
            // xrahmeninmm
            // 
            this.xrahmeninmm.DataPropertyName = "xrahmeninmm";
            this.xrahmeninmm.HeaderText = "xrahmeninmm";
            this.xrahmeninmm.Name = "xrahmeninmm";
            this.xrahmeninmm.ReadOnly = true;
            this.xrahmeninmm.Visible = false;
            // 
            // yrahmeninmm
            // 
            this.yrahmeninmm.DataPropertyName = "yrahmeninmm";
            this.yrahmeninmm.HeaderText = "yrahmeninmm";
            this.yrahmeninmm.Name = "yrahmeninmm";
            this.yrahmeninmm.ReadOnly = true;
            this.yrahmeninmm.Visible = false;
            // 
            // schuetze
            // 
            this.schuetze.DataPropertyName = "schuetze";
            this.schuetze.HeaderText = "schuetze";
            this.schuetze.Name = "schuetze";
            this.schuetze.ReadOnly = true;
            this.schuetze.Visible = false;
            // 
            // disziplin
            // 
            this.disziplin.DataPropertyName = "disziplin";
            this.disziplin.HeaderText = "disziplin";
            this.disziplin.Name = "disziplin";
            this.disziplin.ReadOnly = true;
            this.disziplin.Visible = false;
            // 
            // zielscheibe
            // 
            this.zielscheibe.DataPropertyName = "zielscheibe";
            this.zielscheibe.HeaderText = "zielscheibe";
            this.zielscheibe.Name = "zielscheibe";
            this.zielscheibe.ReadOnly = true;
            this.zielscheibe.Visible = false;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "kaliber";
            this.dataGridViewTextBoxColumn26.HeaderText = "kaliber";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Visible = false;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "ablauf";
            this.dataGridViewTextBoxColumn27.HeaderText = "ablauf";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Visible = false;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "fehler";
            this.dataGridViewTextBoxColumn30.HeaderText = "fehler";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Visible = false;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "session";
            this.dataGridViewTextBoxColumn31.HeaderText = "session";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            this.dataGridViewTextBoxColumn31.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // SchrittText
            // 
            this.SchrittText.HeaderText = "Schritt";
            this.SchrittText.Name = "SchrittText";
            this.SchrittText.ReadOnly = true;
            this.SchrittText.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.SchiessbuchTab);
            this.tabControl1.Controls.Add(this.AuswertungTab);
            this.tabControl1.Controls.Add(this.TagesAuswertung);
            this.tabControl1.Controls.Add(this.KoenigTab);
            this.tabControl1.Controls.Add(this.wanderpokal);
            this.tabControl1.Controls.Add(this.tabStandUebersicht);
            this.tabControl1.Controls.Add(this.tabEinzelscheibe);
            this.tabControl1.Controls.Add(this.tabGemeindemeisterschaft);
            this.tabControl1.Location = new System.Drawing.Point(12, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 445);
            this.tabControl1.TabIndex = 29;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // schuetzenTableAdapter
            // 
            this.schuetzenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.schiessbuchTableAdapter = this.schiessbuchTableAdapter;
            this.tableAdapterManager.schuetzenTableAdapter = this.schuetzenTableAdapter;
            this.tableAdapterManager.trefferTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = schiessbuch.siusclubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // schiessbuchTableAdapter
            // 
            this.schiessbuchTableAdapter.ClearBeforeFill = true;
            // 
            // schuetzenlisteTableAdapter
            // 
            this.schuetzenlisteTableAdapter.ClearBeforeFill = true;
            // 
            // trefferTableAdapter
            // 
            this.trefferTableAdapter.ClearBeforeFill = true;
            // 
            // vereineTableAdapter
            // 
            this.vereineTableAdapter.ClearBeforeFill = true;
            // 
            // uebersichtgemeindemeisterschaftTableAdapter
            // 
            this.uebersichtgemeindemeisterschaftTableAdapter.ClearBeforeFill = true;
            // 
            // vereinslisteTableAdapter
            // 
            this.vereinslisteTableAdapter.ClearBeforeFill = true;
            // 
            // datumlisteTableAdapter
            // 
            this.datumlisteTableAdapter.ClearBeforeFill = true;
            // 
            // vereinsheimSiusclubDataSet1
            // 
            this.vereinsheimSiusclubDataSet1.DataSetName = "VereinsheimSiusclubDataSet1";
            this.vereinsheimSiusclubDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uebersichtgemeindemeisterschaftBindingSource2
            // 
            this.uebersichtgemeindemeisterschaftBindingSource2.DataMember = "uebersichtgemeindemeisterschaft";
            this.uebersichtgemeindemeisterschaftBindingSource2.DataSource = this.vereinsheimSiusclubDataSet1;
            // 
            // uebersichtgemeindemeisterschaftTableAdapter1
            // 
            this.uebersichtgemeindemeisterschaftTableAdapter1.ClearBeforeFill = true;
            // 
            // uebersichtgemeindemeisterschaftTableAdapter3
            // 
            this.uebersichtgemeindemeisterschaftTableAdapter3.ClearBeforeFill = true;
            // 
            // Schiessbuch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 512);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button7);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Schiessbuch";
            this.Text = "Schiessbuch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Schiessbuch_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Schiessbuch_FormClosed);
            this.Load += new System.EventHandler(this.Schiessbuch_Load);
            this.ResizeBegin += new System.EventHandler(this.Schiessbuch_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Schiessbuch_ResizeEnd);
            this.Resize += new System.EventHandler(this.Schiessbuch_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.schuetzenListeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siusclubDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siusclubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schuetzenListeBindingSourceA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schiessbuchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schuetzenBindingSource)).EndInit();
            this.SchiessbuchContexMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schuetzenlisteschiessbuchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trefferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schiessbuchtrefferBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uebersichtgemeindemeisterschaftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gemeindemeisterschaftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gemeindemeisterschaft)).EndInit();
            this.tabGemeindemeisterschaft.ResumeLayout(false);
            this.tabGemeindemeisterschaft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datumlisteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vereinslisteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gmmDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uebersichtgemeindemeisterschaftBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vereinsheimSiusclubDataSet2)).EndInit();
            this.tabEinzelscheibe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEinzelScheibe)).EndInit();
            this.tabStandUebersicht.ResumeLayout(false);
            this.UebersichtTableLayoutPanel.ResumeLayout(false);
            this.Stand1SplitContainer.Panel1.ResumeLayout(false);
            this.Stand1SplitContainer.Panel2.ResumeLayout(false);
            this.Stand1SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stand1SplitContainer)).EndInit();
            this.Stand1SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stand1Zielscheibe)).EndInit();
            this.Stand1SchussPanel.ResumeLayout(false);
            this.Stand1SchussPanel.PerformLayout();
            this.Stand2SplitContainer.Panel1.ResumeLayout(false);
            this.Stand2SplitContainer.Panel2.ResumeLayout(false);
            this.Stand2SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stand2SplitContainer)).EndInit();
            this.Stand2SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stand2Zielscheibe)).EndInit();
            this.Stand2SchussPanel.ResumeLayout(false);
            this.Stand2SchussPanel.PerformLayout();
            this.Stand3SplitContainer.Panel1.ResumeLayout(false);
            this.Stand3SplitContainer.Panel2.ResumeLayout(false);
            this.Stand3SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stand3SplitContainer)).EndInit();
            this.Stand3SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stand3Zielscheibe)).EndInit();
            this.Stand3SchussPanel.ResumeLayout(false);
            this.Stand3SchussPanel.PerformLayout();
            this.Stand6SplitContainer.Panel1.ResumeLayout(false);
            this.Stand6SplitContainer.Panel2.ResumeLayout(false);
            this.Stand6SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stand6SplitContainer)).EndInit();
            this.Stand6SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stand6Zielscheibe)).EndInit();
            this.Stand6SchussPanel.ResumeLayout(false);
            this.Stand6SchussPanel.PerformLayout();
            this.Stand5SplitContainer.Panel1.ResumeLayout(false);
            this.Stand5SplitContainer.Panel2.ResumeLayout(false);
            this.Stand5SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stand5SplitContainer)).EndInit();
            this.Stand5SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stand5Zielscheibe)).EndInit();
            this.Stand5SchussPanel.ResumeLayout(false);
            this.Stand5SchussPanel.PerformLayout();
            this.Stand4SplitContainer.Panel1.ResumeLayout(false);
            this.Stand4SplitContainer.Panel2.ResumeLayout(false);
            this.Stand4SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stand4SplitContainer)).EndInit();
            this.Stand4SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stand4Zielscheibe)).EndInit();
            this.Stand4SchussPanel.ResumeLayout(false);
            this.Stand4SchussPanel.PerformLayout();
            this.wanderpokal.ResumeLayout(false);
            this.wanderpokal.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JahrespokalErwachseneDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JahrespokalJugendDGV)).EndInit();
            this.KoenigTab.ResumeLayout(false);
            this.splitContainerKoenig1.Panel1.ResumeLayout(false);
            this.splitContainerKoenig1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerKoenig1)).EndInit();
            this.splitContainerKoenig1.ResumeLayout(false);
            this.splitContainerKoenig2.Panel1.ResumeLayout(false);
            this.splitContainerKoenig2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerKoenig2)).EndInit();
            this.splitContainerKoenig2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KoenigSKGridView)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KoenigDKGridView)).EndInit();
            this.splitContainerKoenig3.Panel1.ResumeLayout(false);
            this.splitContainerKoenig3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerKoenig3)).EndInit();
            this.splitContainerKoenig3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KoenigAuflageGridView)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KoenigJUGGridView)).EndInit();
            this.TagesAuswertung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Schiessabend)).EndInit();
            this.AuswertungTab.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.SchiessbuchTab.ResumeLayout(false);
            this.SchiessbuchTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vereineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siusclubDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schiessbuchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trefferDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vereinsheimSiusclubDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uebersichtgemeindemeisterschaftBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private siusclubDataSet siusclubDataSet;
        private System.Windows.Forms.BindingSource schuetzenBindingSource;
        private schuetzenTableAdapter schuetzenTableAdapter;
        private TableAdapterManager tableAdapterManager;
        private schiessbuchTableAdapter schiessbuchTableAdapter;
        private System.Windows.Forms.BindingSource schiessbuchBindingSource;
        private System.Windows.Forms.BindingSource trefferBindingSource;
        private trefferTableAdapter trefferTableAdapter;
        //private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitungsmodusToolStripMenuItem;
        private siusclubDataSet siusclubDataSet1;
        private System.Windows.Forms.BindingSource vereineBindingSource;
        private VereineTableAdapter vereineTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem schießjahrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesSchießjahrBeginnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schießjahrAuswählenToolStripMenuItem;
        private System.Windows.Forms.BindingSource siusclubDataSetBindingSource;
        private System.Windows.Forms.ContextMenuStrip SchiessbuchContexMenu;
        private System.Windows.Forms.ToolStripMenuItem moveEntry;
        private System.Windows.Forms.ToolStripMenuItem deleteEntry;
        private System.Windows.Forms.ToolStripMenuItem eintratgültigSetzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordnerFürSicherungenFestlegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pfadZuMysqldumpFestlegenToolStripMenuItem;
        private schiessbuch.siusclubDataSetTableAdapters.schuetzenlisteTableAdapter schuetzenlisteTableAdapter;
        private BindingSource schuetzenListeBindingSourceA;
        private BindingSource schuetzenListeBindingSource;
        private BindingSource schuetzenlisteschiessbuchBindingSource;
        private BindingSource schiessbuchtrefferBindingSource;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem einstellungenToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem auswertenEntry;
        private Button button5;
        private Button button7;
        private gemeindemeisterschaft gemeindemeisterschaft;
        private gemeindemeisterschaftTableAdapters.uebersichtgemeindemeisterschaftTableAdapter uebersichtgemeindemeisterschaftTableAdapter;
        private BindingSource gemeindemeisterschaftBindingSource;
        private BindingSource vereinslisteBindingSource;
        private gemeindemeisterschaftTableAdapters.vereinslisteTableAdapter vereinslisteTableAdapter;
        private BindingSource datumlisteBindingSource;
        private gemeindemeisterschaftTableAdapters.datumlisteTableAdapter datumlisteTableAdapter;
        private BindingSource uebersichtgemeindemeisterschaftBindingSource;
        private VereinsheimSiusclubDataSet1 vereinsheimSiusclubDataSet1;
        private BindingSource uebersichtgemeindemeisterschaftBindingSource2;
        private VereinsheimSiusclubDataSet1TableAdapters.uebersichtgemeindemeisterschaftTableAdapter uebersichtgemeindemeisterschaftTableAdapter1;
        // private siusclubDataSet1 siusclubDataSet11;
        // private BindingSource uebersichtgemeindemeisterschaftBindingSource3;
        private VereinsheimSiusclubDataSet2 vereinsheimSiusclubDataSet2;
        private BindingSource uebersichtgemeindemeisterschaftBindingSource4;
        private VereinsheimSiusclubDataSet2TableAdapters.uebersichtgemeindemeisterschaftTableAdapter uebersichtgemeindemeisterschaftTableAdapter3;
        private TabPage tabGemeindemeisterschaft;
        private Label label13;
        private CheckBox cbDatumFiltern;
        private Button btnRefresh;
        private CheckBox cbVereineFiltern;
        private ComboBox comboDatumFiltern;
        private ComboBox comboVereineFiltern;
        private Button btnGmmDruck;
        private DataGridView gmmDGV;
        private DataGridViewTextBoxColumn vereinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn klasseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gemeindemeisterLuftgewehrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gemeindemeisterLuftpistoleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gemeindemeisterLuftgewehrAuflageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gemeindemeisterLuftpistoleAuflageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn preisLuftgewehrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn preisLuftpistoleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn preisLuftgewehrAuflageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn preisLuftpistoleAuflageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bürgermeisterpokalLuftgewehrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bürgermeisterpokalLuftpistoleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bürgermeisterpokalLuftgewehrAuflageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bürgermeisterpokalLuftpistoleAuflageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gedächtnispokalLuftgewehrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gedächtnispokalLuftpistoleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gedächtnispokalLuftgewehrAuflageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gedächtnispokalLuftpistoleAuflageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn schiessjahrIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn schuetzeIDDataGridViewTextBoxColumn;
        private TabPage tabEinzelscheibe;
        private PictureBox pictureBoxEinzelScheibe;
        private TabPage tabStandUebersicht;
        private TabPage wanderpokal;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label9;
        private DataGridView JahrespokalErwachseneDGV;
        private DataGridView JahrespokalJugendDGV;
        private Label labelWPSK;
        private Button button3;
        private Button button2;
        private Label labelTermin2;
        private DateTimePicker dateTimeWPTermin2;
        private Label labelTermin3;
        private DateTimePicker dateTimeWPTermin3;
        private Label labelTermin4;
        private DateTimePicker dateTimeWPTermin4;
        private Label labelTermin5;
        private DateTimePicker dateTimeWPTermin5;
        private Label labelTermin6;
        private DateTimePicker dateTimeWPTermin6;
        private Label labelTermin7;
        private DateTimePicker dateTimeWPTermin7;
        private Label labelTermin8;
        private DateTimePicker dateTimeWPTermin8;
        private Label labelTermin9;
        private DateTimePicker dateTimeWPTermin9;
        private Label labelTermin10;
        private DateTimePicker dateTimeWPTermin10;
        private Label labelTermin11;
        private DateTimePicker dateTimeWPTermin11;
        private Label labelTermin12;
        private DateTimePicker dateTimeWPTermin12;
        private Label labelTermin1;
        private DateTimePicker dateTimeWPTermin1;
        private TabPage KoenigTab;
        private SplitContainer splitContainerKoenig1;
        private SplitContainer splitContainerKoenig2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label SchuetzenklasseLabel;
        private DataGridView KoenigSKGridView;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Fullname;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Teiler;
        private DataGridViewTextBoxColumn Typ;
        private TableLayoutPanel tableLayoutPanel5;
        private Label SchuetzenlieslLabel;
        private DataGridView KoenigDKGridView;
        private DataGridViewTextBoxColumn PositionDK;
        private DataGridViewTextBoxColumn FullnameDK;
        private DataGridViewTextBoxColumn DatumDK;
        private DataGridViewTextBoxColumn TeilerDK;
        private DataGridViewTextBoxColumn TypDK;
        private SplitContainer splitContainerKoenig3;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label7;
        private DataGridView KoenigAuflageGridView;
        private DataGridViewTextBoxColumn PositionAuflage;
        private DataGridViewTextBoxColumn FullnameAuflage;
        private DataGridViewTextBoxColumn DatumAuflage;
        private DataGridViewTextBoxColumn TeilerAuflage;
        private DataGridViewTextBoxColumn TypAuflage;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label8;
        private DataGridView KoenigJUGGridView;
        private DataGridViewTextBoxColumn PositionJUG;
        private DataGridViewTextBoxColumn FullnameJUG;
        private DataGridViewTextBoxColumn DatumJUG;
        private DataGridViewTextBoxColumn TeilerJUG;
        private DataGridViewTextBoxColumn TypJUG;
        private TabPage TagesAuswertung;
        private Button btnKassenbericht;
        private Button button4;
        private Button btnTagesAuswertungListeDrucken;
        private Button btnTagesAuswertungDrucken;
        private DateTimePicker dateTimePicker1;
        private DataGridView Schiessabend;
        private TabPage AuswertungTab;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox AuswertungLG30;
        private TextBox AuswertungLG20;
        private TextBox AuswertungLG20_15;
        private TextBox AuswertungLG30_15;
        private TextBox AuswertungLG40;
        private TextBox AuswertungLG40_15;
        private TabPage tabPage5;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox AuswertungLG30A;
        private TextBox AuswertungLG30A_15;
        private TextBox AuswertungLG40A;
        private TextBox AuswertungLG40A_15;
        private TextBox AuswertungLG20A_15;
        private TextBox AuswertungLG20A;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox AuswertungLP30;
        private TextBox AuswertungLP20;
        private TextBox AuswertungLP20_15;
        private TextBox AuswertungLP30_15;
        private TextBox AuswertungLP40;
        private TextBox AuswertungLP40_15;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private ComboBox SchuetzeComboBox;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private TabPage SchiessbuchTab;
        private GroupBox groupBox1;
        private TextBox KlasseName;
        private TextBox geburtsdatumTextBox;
        private TextBox geschlechtTextBox;
        private Label lblWanderpokalschiessen;
        private Button button1;
        private ComboBox vereinComboBox;
        private CheckBox DoUpdates;
        private Label fullnameLabel;
        private Label idLabel;
        private ComboBox fullnameComboBox;
        private TextBox idTextBox;
        private TextBox vereinTextBox;
        private Label nameLabel;
        private Label vereinLabel;
        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private Label vornameLabel;
        private Label emailLabel;
        private TextBox vornameTextBox;
        private DateTimePicker GeburtstagDateTimePicker;
        private CheckBox checkBox1;
        private DateTimePicker SchiessabendPicker;
        private PictureBox pictureBox1;
        private DataGridView schiessbuchDataGridView;
        private Label zielscheibeLabel;
        private TextBox zielscheibeTextBox;
        private DataGridView trefferDataGridView;
        private DataGridViewTextBoxColumn schritt;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private DataGridViewTextBoxColumn schussnummer;
        private DataGridViewTextBoxColumn ring;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn xinmm;
        private DataGridViewTextBoxColumn yinmm;
        private DataGridViewTextBoxColumn xrahmeninmm;
        private DataGridViewTextBoxColumn yrahmeninmm;
        private DataGridViewTextBoxColumn schuetze;
        private DataGridViewTextBoxColumn disziplin;
        private DataGridViewTextBoxColumn zielscheibe;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn SchrittText;
        private TabControl tabControl1;
        private TableLayoutPanel UebersichtTableLayoutPanel;
        private SplitContainer Stand1SplitContainer;
        private PictureBox stand1Zielscheibe;
        private Label lblProbe1;
        private Label txtSchussStand1;
        private Label lblSchussStand1;
        private Label txtDisziplinStand1;
        private Label lblDisziplinStand1;
        private Label txtSchuetzeStand1;
        private Label lblSchuetzeStand1;
        private TableLayoutPanel Stand1SchussPanel;
        private Label txtSchuss100;
        private Label txtSchuss110;
        private Label txtSchuss120;
        private Label txtSchuss130;
        private Label txtSchuss140;
        private Label txtSchuss101;
        private Label txtSchuss111;
        private Label txtSchuss121;
        private Label txtSchuss131;
        private Label txtSchuss141;
        private Label txtSchuss102;
        private Label txtSchuss112;
        private Label txtSchuss122;
        private Label txtSchuss132;
        private Label txtSchuss142;
        private Label txtSchuss103;
        private Label txtSchuss113;
        private Label txtSchuss123;
        private Label txtSchuss133;
        private Label txtSchuss143;
        private Label txtSchuss104;
        private Label txtSchuss114;
        private Label txtSchuss124;
        private Label txtSchuss134;
        private Label txtSchuss144;
        private Label txtSchuss105;
        private Label txtSchuss115;
        private Label txtSchuss125;
        private Label txtSchuss135;
        private Label txtSchuss145;
        private Label txtSchuss106;
        private Label txtSchuss116;
        private Label txtSchuss126;
        private Label txtSchuss136;
        private Label txtSchuss146;
        private Label txtSchuss107;
        private Label txtSchuss117;
        private Label txtSchuss127;
        private Label txtSchuss137;
        private Label txtSchuss147;
        private SplitContainer Stand2SplitContainer;
        private PictureBox stand2Zielscheibe;
        private Label lblProbe2;
        private Label txtSchussStand2;
        private Label lblSchussStand2;
        private Label txtDisziplinStand2;
        private Label lblDisziplinStand2;
        private Label txtSchuetzeStand2;
        private Label lblSchuetzeStand2;
        private TableLayoutPanel Stand2SchussPanel;
        private Label txtSchuss200;
        private Label txtSchuss210;
        private Label txtSchuss220;
        private Label txtSchuss230;
        private Label txtSchuss240;
        private Label txtSchuss201;
        private Label txtSchuss211;
        private Label txtSchuss221;
        private Label txtSchuss231;
        private Label txtSchuss241;
        private Label txtSchuss202;
        private Label txtSchuss212;
        private Label txtSchuss222;
        private Label txtSchuss232;
        private Label txtSchuss242;
        private Label txtSchuss203;
        private Label txtSchuss213;
        private Label txtSchuss223;
        private Label txtSchuss233;
        private Label txtSchuss243;
        private Label txtSchuss204;
        private Label txtSchuss214;
        private Label txtSchuss224;
        private Label txtSchuss234;
        private Label txtSchuss244;
        private Label txtSchuss205;
        private Label txtSchuss215;
        private Label txtSchuss225;
        private Label txtSchuss235;
        private Label txtSchuss245;
        private Label txtSchuss206;
        private Label txtSchuss216;
        private Label txtSchuss226;
        private Label txtSchuss236;
        private Label txtSchuss246;
        private Label txtSchuss207;
        private Label txtSchuss217;
        private Label txtSchuss227;
        private Label txtSchuss237;
        private Label txtSchuss247;
        private SplitContainer Stand3SplitContainer;
        private PictureBox stand3Zielscheibe;
        private Label lblProbe3;
        private Label txtSchussStand3;
        private Label lblSchussStand3;
        private Label txtDisziplinStand3;
        private Label lblDisziplinStand3;
        private Label txtSchuetzeStand3;
        private Label lblSchuetzeStand3;
        private TableLayoutPanel Stand3SchussPanel;
        private Label txtSchuss300;
        private Label txtSchuss310;
        private Label txtSchuss320;
        private Label txtSchuss330;
        private Label txtSchuss340;
        private Label txtSchuss301;
        private Label txtSchuss311;
        private Label txtSchuss321;
        private Label txtSchuss331;
        private Label txtSchuss341;
        private Label txtSchuss302;
        private Label txtSchuss312;
        private Label txtSchuss322;
        private Label txtSchuss332;
        private Label txtSchuss342;
        private Label txtSchuss303;
        private Label txtSchuss313;
        private Label txtSchuss323;
        private Label txtSchuss333;
        private Label txtSchuss343;
        private Label txtSchuss304;
        private Label txtSchuss314;
        private Label txtSchuss324;
        private Label txtSchuss334;
        private Label txtSchuss344;
        private Label txtSchuss305;
        private Label txtSchuss315;
        private Label txtSchuss325;
        private Label txtSchuss335;
        private Label txtSchuss345;
        private Label txtSchuss306;
        private Label txtSchuss316;
        private Label txtSchuss326;
        private Label txtSchuss336;
        private Label txtSchuss346;
        private Label txtSchuss307;
        private Label txtSchuss317;
        private Label txtSchuss327;
        private Label txtSchuss337;
        private Label txtSchuss347;
        private SplitContainer Stand6SplitContainer;
        private PictureBox stand6Zielscheibe;
        private Label lblProbe6;
        private Label txtSchussStand6;
        private Label lblSchussStand6;
        private Label txtDisziplinStand6;
        private Label lblDisziplinStand6;
        private Label txtSchuetzeStand6;
        private Label lblSchuetzeStand6;
        private TableLayoutPanel Stand6SchussPanel;
        private Label txtSchuss600;
        private Label txtSchuss610;
        private Label txtSchuss620;
        private Label txtSchuss630;
        private Label txtSchuss640;
        private Label txtSchuss601;
        private Label txtSchuss611;
        private Label txtSchuss621;
        private Label txtSchuss631;
        private Label txtSchuss641;
        private Label txtSchuss602;
        private Label txtSchuss612;
        private Label txtSchuss622;
        private Label txtSchuss632;
        private Label txtSchuss642;
        private Label txtSchuss603;
        private Label txtSchuss613;
        private Label txtSchuss623;
        private Label txtSchuss633;
        private Label txtSchuss643;
        private Label txtSchuss604;
        private Label txtSchuss614;
        private Label txtSchuss624;
        private Label txtSchuss634;
        private Label txtSchuss644;
        private Label txtSchuss605;
        private Label txtSchuss615;
        private Label txtSchuss625;
        private Label txtSchuss635;
        private Label txtSchuss645;
        private Label txtSchuss606;
        private Label txtSchuss616;
        private Label txtSchuss626;
        private Label txtSchuss636;
        private Label txtSchuss646;
        private Label txtSchuss607;
        private Label txtSchuss617;
        private Label txtSchuss627;
        private Label txtSchuss637;
        private Label txtSchuss647;
        private SplitContainer Stand5SplitContainer;
        private PictureBox stand5Zielscheibe;
        private Label lblProbe5;
        private Label txtSchussStand5;
        private Label lblSchussStand5;
        private Label txtDisziplinStand5;
        private Label lblDisziplinStand5;
        private Label txtSchuetzeStand5;
        private Label lblSchuetzeStand5;
        private TableLayoutPanel Stand5SchussPanel;
        private Label txtSchuss500;
        private Label txtSchuss510;
        private Label txtSchuss520;
        private Label txtSchuss530;
        private Label txtSchuss540;
        private Label txtSchuss501;
        private Label txtSchuss511;
        private Label txtSchuss521;
        private Label txtSchuss531;
        private Label txtSchuss541;
        private Label txtSchuss502;
        private Label txtSchuss512;
        private Label txtSchuss522;
        private Label txtSchuss532;
        private Label txtSchuss542;
        private Label txtSchuss503;
        private Label txtSchuss513;
        private Label txtSchuss523;
        private Label txtSchuss533;
        private Label txtSchuss543;
        private Label txtSchuss504;
        private Label txtSchuss514;
        private Label txtSchuss524;
        private Label txtSchuss534;
        private Label txtSchuss544;
        private Label txtSchuss505;
        private Label txtSchuss515;
        private Label txtSchuss525;
        private Label txtSchuss535;
        private Label txtSchuss545;
        private Label txtSchuss506;
        private Label txtSchuss516;
        private Label txtSchuss526;
        private Label txtSchuss536;
        private Label txtSchuss546;
        private Label txtSchuss507;
        private Label txtSchuss517;
        private Label txtSchuss527;
        private Label txtSchuss537;
        private Label txtSchuss547;
        private SplitContainer Stand4SplitContainer;
        private PictureBox stand4Zielscheibe;
        private Label lblProbe4;
        private TableLayoutPanel Stand4SchussPanel;
        private Label txtSchuss400;
        private Label txtSchuss410;
        private Label txtSchuss420;
        private Label txtSchuss430;
        private Label txtSchuss440;
        private Label txtSchuss401;
        private Label txtSchuss411;
        private Label txtSchuss421;
        private Label txtSchuss431;
        private Label txtSchuss441;
        private Label txtSchuss402;
        private Label txtSchuss412;
        private Label txtSchuss422;
        private Label txtSchuss432;
        private Label txtSchuss442;
        private Label txtSchuss403;
        private Label txtSchuss413;
        private Label txtSchuss423;
        private Label txtSchuss433;
        private Label txtSchuss443;
        private Label txtSchuss404;
        private Label txtSchuss414;
        private Label txtSchuss424;
        private Label txtSchuss434;
        private Label txtSchuss444;
        private Label txtSchuss405;
        private Label txtSchuss415;
        private Label txtSchuss425;
        private Label txtSchuss435;
        private Label txtSchuss445;
        private Label txtSchuss406;
        private Label txtSchuss416;
        private Label txtSchuss426;
        private Label txtSchuss436;
        private Label txtSchuss446;
        private Label txtSchuss407;
        private Label txtSchuss417;
        private Label txtSchuss427;
        private Label txtSchuss437;
        private Label txtSchuss447;
        private Label lblSchussStand4;
        private Label txtSchussStand4;
        private Label lblDisziplinStand4;
        private Label txtDisziplinStand4;
        private Label lblSchuetzeStand4;
        private Label txtSchuetzeStand4;
        private ToolStripMenuItem vereinsmeisterToolStripMenuItem;
        private ToolStripMenuItem jahresübersichtToolStripMenuItem;
        private ToolStripMenuItem disziplinkorrigierenToolStripMenuItem;
        private DataGridViewTextBoxColumn colDisziplin;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn session;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dt;
    }
}

