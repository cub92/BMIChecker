
namespace BMIChecker
{
    partial class FormBMIChecker
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelHight = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelBMI = new System.Windows.Forms.Label();
            this.textBoxBMI = new System.Windows.Forms.TextBox();
            this.labelJudgment = new System.Windows.Forms.Label();
            this.textBoxJudgment = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMI計算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入力クリアNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.標準体重SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHight
            // 
            this.labelHight.AutoSize = true;
            this.labelHight.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelHight.Location = new System.Drawing.Point(21, 42);
            this.labelHight.Name = "labelHight";
            this.labelHight.Size = new System.Drawing.Size(76, 16);
            this.labelHight.TabIndex = 0;
            this.labelHight.Text = "身長（cm）";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label.Location = new System.Drawing.Point(21, 79);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(73, 16);
            this.label.TabIndex = 1;
            this.label.Text = "体重（Kg）";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxHeight.Location = new System.Drawing.Point(142, 43);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 23);
            this.textBoxHeight.TabIndex = 1;
            this.textBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxWeight.Location = new System.Drawing.Point(142, 76);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 23);
            this.textBoxWeight.TabIndex = 2;
            this.textBoxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonCalc.Location = new System.Drawing.Point(24, 123);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(218, 37);
            this.buttonCalc.TabIndex = 3;
            this.buttonCalc.Text = "計算";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelBMI
            // 
            this.labelBMI.AutoSize = true;
            this.labelBMI.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelBMI.Location = new System.Drawing.Point(24, 192);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(34, 16);
            this.labelBMI.TabIndex = 1;
            this.labelBMI.Text = "BMI";
            // 
            // textBoxBMI
            // 
            this.textBoxBMI.Enabled = false;
            this.textBoxBMI.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxBMI.Location = new System.Drawing.Point(142, 189);
            this.textBoxBMI.Name = "textBoxBMI";
            this.textBoxBMI.Size = new System.Drawing.Size(100, 23);
            this.textBoxBMI.TabIndex = 2;
            this.textBoxBMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelJudgment
            // 
            this.labelJudgment.AutoSize = true;
            this.labelJudgment.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelJudgment.Location = new System.Drawing.Point(24, 240);
            this.labelJudgment.Name = "labelJudgment";
            this.labelJudgment.Size = new System.Drawing.Size(40, 16);
            this.labelJudgment.TabIndex = 1;
            this.labelJudgment.Text = "判定";
            // 
            // textBoxJudgment
            // 
            this.textBoxJudgment.Enabled = false;
            this.textBoxJudgment.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxJudgment.Location = new System.Drawing.Point(142, 237);
            this.textBoxJudgment.Name = "textBoxJudgment";
            this.textBoxJudgment.Size = new System.Drawing.Size(100, 23);
            this.textBoxJudgment.TabIndex = 2;
            this.textBoxJudgment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.bMIToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.終了ToolStripMenuItem.Text = "終了(&X)";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // bMIToolStripMenuItem
            // 
            this.bMIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMI計算ToolStripMenuItem,
            this.入力クリアNToolStripMenuItem,
            this.toolStripSeparator1,
            this.標準体重SToolStripMenuItem});
            this.bMIToolStripMenuItem.Name = "bMIToolStripMenuItem";
            this.bMIToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.bMIToolStripMenuItem.Text = "BMI(&B)";
            // 
            // bMI計算ToolStripMenuItem
            // 
            this.bMI計算ToolStripMenuItem.Name = "bMI計算ToolStripMenuItem";
            this.bMI計算ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.bMI計算ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.bMI計算ToolStripMenuItem.Text = "BMI計算(&C)";
            this.bMI計算ToolStripMenuItem.Click += new System.EventHandler(this.bMI計算ToolStripMenuItem_Click);
            // 
            // 入力クリアNToolStripMenuItem
            // 
            this.入力クリアNToolStripMenuItem.Name = "入力クリアNToolStripMenuItem";
            this.入力クリアNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.入力クリアNToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.入力クリアNToolStripMenuItem.Text = "入力クリア(&N)";
            this.入力クリアNToolStripMenuItem.Click += new System.EventHandler(this.入力クリアNToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // 標準体重SToolStripMenuItem
            // 
            this.標準体重SToolStripMenuItem.Name = "標準体重SToolStripMenuItem";
            this.標準体重SToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.標準体重SToolStripMenuItem.Text = "標準体重(&S)";
            this.標準体重SToolStripMenuItem.Click += new System.EventHandler(this.標準体重SToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BMIChecker.Properties.Resources.istockphoto_859587780_612x612;
            this.panel1.Location = new System.Drawing.Point(248, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 408);
            this.panel1.TabIndex = 5;
            // 
            // FormBMIChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxJudgment);
            this.Controls.Add(this.textBoxBMI);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.labelJudgment);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelBMI);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelHight);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormBMIChecker";
            this.Text = "BMIチェッカー";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHight;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelBMI;
        private System.Windows.Forms.TextBox textBoxBMI;
        private System.Windows.Forms.Label labelJudgment;
        private System.Windows.Forms.TextBox textBoxJudgment;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMI計算ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 入力クリアNToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 標準体重SToolStripMenuItem;
    }
}

