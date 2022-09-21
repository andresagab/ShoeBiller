
namespace ShoeBiller
{
    partial class FrmDataNavigator
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
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.txtRecord = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnBefore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecords.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalRecords.Location = new System.Drawing.Point(12, 10);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(116, 19);
            this.lblTotalRecords.TabIndex = 12;
            this.lblTotalRecords.Text = "N° de registros: 0";
            // 
            // txtRecord
            // 
            this.txtRecord.Location = new System.Drawing.Point(706, 10);
            this.txtRecord.MaximumSize = new System.Drawing.Size(30, 30);
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.Size = new System.Drawing.Size(30, 20);
            this.txtRecord.TabIndex = 15;
            this.txtRecord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecord_KeyPress);
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Image = global::ShoeBiller.Properties.Resources.navigate_next_FILL1_wght400_GRAD0_opsz24;
            this.btnNext.Location = new System.Drawing.Point(742, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 16;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.AutoSize = true;
            this.btnLast.BackColor = System.Drawing.Color.Transparent;
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLast.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLast.Image = global::ShoeBiller.Properties.Resources.skip_next_FILL1_wght400_GRAD0_opsz24;
            this.btnLast.Location = new System.Drawing.Point(778, 5);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(30, 30);
            this.btnLast.TabIndex = 17;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.AutoSize = true;
            this.btnFirst.BackColor = System.Drawing.Color.Transparent;
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFirst.Image = global::ShoeBiller.Properties.Resources.skip_previous_FILL1_wght400_GRAD0_opsz24;
            this.btnFirst.Location = new System.Drawing.Point(634, 5);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(30, 30);
            this.btnFirst.TabIndex = 13;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnBefore
            // 
            this.btnBefore.AutoSize = true;
            this.btnBefore.BackColor = System.Drawing.Color.Transparent;
            this.btnBefore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBefore.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBefore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBefore.Image = global::ShoeBiller.Properties.Resources.navigate_before_FILL1_wght400_GRAD0_opsz24;
            this.btnBefore.Location = new System.Drawing.Point(670, 5);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(30, 30);
            this.btnBefore.TabIndex = 14;
            this.btnBefore.UseVisualStyleBackColor = false;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // FrmDataNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 40);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.txtRecord);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnBefore);
            this.Controls.Add(this.lblTotalRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDataNavigator";
            this.Text = "DataNavigator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.TextBox txtRecord;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
    }
}