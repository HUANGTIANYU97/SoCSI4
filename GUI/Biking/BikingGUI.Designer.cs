namespace Biking
{
    partial class BikingGUI
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.Button();
            this.CityList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Departure = new System.Windows.Forms.TextBox();
            this.Destination = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Map = new System.Windows.Forms.WebBrowser();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Let\'s go biking!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Help
            // 
            this.Help.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.Location = new System.Drawing.Point(305, 31);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(98, 32);
            this.Help.TabIndex = 1;
            this.Help.Text = "help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // CityList
            // 
            this.CityList.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityList.FormattingEnabled = true;
            this.CityList.ItemHeight = 24;
            this.CityList.Location = new System.Drawing.Point(48, 353);
            this.CityList.Name = "CityList";
            this.CityList.Size = new System.Drawing.Size(102, 460);
            this.CityList.TabIndex = 2;
            this.CityList.SelectedIndexChanged += new System.EventHandler(this.CityList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose the city:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Departure
            // 
            this.Departure.Location = new System.Drawing.Point(364, 307);
            this.Departure.Name = "Departure";
            this.Departure.Size = new System.Drawing.Size(244, 21);
            this.Departure.TabIndex = 4;
            this.Departure.TextChanged += new System.EventHandler(this.Departure_TextChanged);
            // 
            // Destination
            // 
            this.Destination.Location = new System.Drawing.Point(364, 353);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(244, 21);
            this.Destination.TabIndex = 5;
            this.Destination.TextChanged += new System.EventHandler(this.Destination_TextChanged);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(642, 323);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(86, 32);
            this.Search.TabIndex = 6;
            this.Search.Text = "search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button2_Click);
            // 
            // Map
            // 
            this.Map.Location = new System.Drawing.Point(242, 413);
            this.Map.MinimumSize = new System.Drawing.Size(20, 20);
            this.Map.Name = "Map";
            this.Map.ScriptErrorsSuppressed = true;
            this.Map.Size = new System.Drawing.Size(1115, 662);
            this.Map.TabIndex = 7;
            this.Map.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Map_DocumentCompleted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Departure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Destination";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(35, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Choose a period";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.button6.Location = new System.Drawing.Point(200, 184);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(297, 31);
            this.button6.TabIndex = 18;
            this.button6.Text = "show all the monitering information";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(521, 88);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(469, 198);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(200, 149);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(216, 20);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // BikingGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 845);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.Departure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CityList);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.label1);
            this.Name = "BikingGUI";
            this.Text = "Let\'s go biking!";
            this.Load += new System.EventHandler(this.BikingGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.ListBox CityList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Departure;
        private System.Windows.Forms.TextBox Destination;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.WebBrowser Map;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

