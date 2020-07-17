﻿namespace WindowsFormsDBDisplay
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.familyDataSet = new WindowsFormsDBDisplay.FamilyDataSet();
            this.familyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familyTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familyTableTableAdapter = new WindowsFormsDBDisplay.FamilyDataSetTableAdapters.FamilyTableTableAdapter();
            this.familyMemberNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hometownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.familyMemberNoDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.hometownDataGridViewTextBoxColumn,
            this.relationshipDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.familyTableBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // familyDataSet
            // 
            this.familyDataSet.DataSetName = "FamilyDataSet";
            this.familyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // familyDataSetBindingSource
            // 
            this.familyDataSetBindingSource.DataSource = this.familyDataSet;
            this.familyDataSetBindingSource.Position = 0;
            // 
            // familyTableBindingSource
            // 
            this.familyTableBindingSource.DataMember = "FamilyTable";
            this.familyTableBindingSource.DataSource = this.familyDataSetBindingSource;
            // 
            // familyTableTableAdapter
            // 
            this.familyTableTableAdapter.ClearBeforeFill = true;
            // 
            // familyMemberNoDataGridViewTextBoxColumn
            // 
            this.familyMemberNoDataGridViewTextBoxColumn.DataPropertyName = "familyMemberNo";
            this.familyMemberNoDataGridViewTextBoxColumn.HeaderText = "familyMemberNo";
            this.familyMemberNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.familyMemberNoDataGridViewTextBoxColumn.Name = "familyMemberNoDataGridViewTextBoxColumn";
            this.familyMemberNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // hometownDataGridViewTextBoxColumn
            // 
            this.hometownDataGridViewTextBoxColumn.DataPropertyName = "hometown";
            this.hometownDataGridViewTextBoxColumn.HeaderText = "hometown";
            this.hometownDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hometownDataGridViewTextBoxColumn.Name = "hometownDataGridViewTextBoxColumn";
            this.hometownDataGridViewTextBoxColumn.Width = 150;
            // 
            // relationshipDataGridViewTextBoxColumn
            // 
            this.relationshipDataGridViewTextBoxColumn.DataPropertyName = "relationship";
            this.relationshipDataGridViewTextBoxColumn.HeaderText = "relationship";
            this.relationshipDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.relationshipDataGridViewTextBoxColumn.Name = "relationshipDataGridViewTextBoxColumn";
            this.relationshipDataGridViewTextBoxColumn.Width = 150;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource familyDataSetBindingSource;
        private FamilyDataSet familyDataSet;
        private System.Windows.Forms.BindingSource familyTableBindingSource;
        private FamilyDataSetTableAdapters.FamilyTableTableAdapter familyTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyMemberNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hometownDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationshipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    }
}

