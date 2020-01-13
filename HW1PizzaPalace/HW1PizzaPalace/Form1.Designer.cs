namespace HW1PizzaPalace
{
    partial class pizzaPalace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pizzaPalace));
            this.orderButton = new System.Windows.Forms.Button();
            this.mattlabel = new System.Windows.Forms.Label();
            this.Pep = new System.Windows.Forms.CheckBox();
            this.chicken = new System.Windows.Forms.CheckBox();
            this.mushroom = new System.Windows.Forms.CheckBox();
            this.bacon = new System.Windows.Forms.CheckBox();
            this.pineapple = new System.Windows.Forms.CheckBox();
            this.pepper = new System.Windows.Forms.CheckBox();
            this.smallRadio = new System.Windows.Forms.RadioButton();
            this.mediumRadio = new System.Windows.Forms.RadioButton();
            this.largeRadio = new System.Windows.Forms.RadioButton();
            this.toppingGroups = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeGroups = new System.Windows.Forms.GroupBox();
            this.tipBox = new System.Windows.Forms.TextBox();
            this.tip = new System.Windows.Forms.Label();
            this.Totals = new System.Windows.Forms.GroupBox();
            this.total = new System.Windows.Forms.Label();
            this.tax3 = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toppingGroups.SuspendLayout();
            this.sizeGroups.SuspendLayout();
            this.Totals.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderButton
            // 
            this.orderButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.orderButton.Location = new System.Drawing.Point(41, 157);
            this.orderButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(128, 31);
            this.orderButton.TabIndex = 0;
            this.orderButton.Text = "Add to Order!";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // mattlabel
            // 
            this.mattlabel.AutoSize = true;
            this.mattlabel.BackColor = System.Drawing.Color.Transparent;
            this.mattlabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.mattlabel.Location = new System.Drawing.Point(19, 125);
            this.mattlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mattlabel.Name = "mattlabel";
            this.mattlabel.Size = new System.Drawing.Size(134, 17);
            this.mattlabel.TabIndex = 1;
            this.mattlabel.Text = "Order Total . . . ";
            // 
            // Pep
            // 
            this.Pep.AutoSize = true;
            this.Pep.Location = new System.Drawing.Point(38, 25);
            this.Pep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Pep.Name = "Pep";
            this.Pep.Size = new System.Drawing.Size(142, 28);
            this.Pep.TabIndex = 3;
            this.Pep.Text = "Pepperoni";
            this.Pep.UseVisualStyleBackColor = true;
            this.Pep.CheckedChanged += new System.EventHandler(this.Pep_CheckedChanged);
            // 
            // chicken
            // 
            this.chicken.AutoSize = true;
            this.chicken.Location = new System.Drawing.Point(38, 68);
            this.chicken.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chicken.Name = "chicken";
            this.chicken.Size = new System.Drawing.Size(115, 28);
            this.chicken.TabIndex = 4;
            this.chicken.Text = "Chicken";
            this.chicken.UseVisualStyleBackColor = true;
            this.chicken.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // mushroom
            // 
            this.mushroom.AutoSize = true;
            this.mushroom.Location = new System.Drawing.Point(38, 110);
            this.mushroom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mushroom.Name = "mushroom";
            this.mushroom.Size = new System.Drawing.Size(146, 28);
            this.mushroom.TabIndex = 5;
            this.mushroom.Text = "Mushroom";
            this.mushroom.UseVisualStyleBackColor = true;
            this.mushroom.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // bacon
            // 
            this.bacon.AutoSize = true;
            this.bacon.Location = new System.Drawing.Point(38, 159);
            this.bacon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bacon.Name = "bacon";
            this.bacon.Size = new System.Drawing.Size(97, 28);
            this.bacon.TabIndex = 6;
            this.bacon.Text = "Bacon";
            this.bacon.UseVisualStyleBackColor = true;
            this.bacon.CheckedChanged += new System.EventHandler(this.bacon_CheckedChanged);
            // 
            // pineapple
            // 
            this.pineapple.AutoSize = true;
            this.pineapple.Location = new System.Drawing.Point(38, 212);
            this.pineapple.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pineapple.Name = "pineapple";
            this.pineapple.Size = new System.Drawing.Size(139, 28);
            this.pineapple.TabIndex = 7;
            this.pineapple.Text = "Pineapple";
            this.pineapple.UseVisualStyleBackColor = true;
            this.pineapple.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // pepper
            // 
            this.pepper.AutoSize = true;
            this.pepper.Location = new System.Drawing.Point(38, 261);
            this.pepper.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pepper.Name = "pepper";
            this.pepper.Size = new System.Drawing.Size(107, 28);
            this.pepper.TabIndex = 8;
            this.pepper.Text = "Pepper";
            this.pepper.UseVisualStyleBackColor = true;
            this.pepper.CheckedChanged += new System.EventHandler(this.pepper_CheckedChanged);
            // 
            // smallRadio
            // 
            this.smallRadio.AutoSize = true;
            this.smallRadio.ForeColor = System.Drawing.SystemColors.Menu;
            this.smallRadio.Location = new System.Drawing.Point(29, 50);
            this.smallRadio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.smallRadio.Name = "smallRadio";
            this.smallRadio.Size = new System.Drawing.Size(134, 28);
            this.smallRadio.TabIndex = 9;
            this.smallRadio.TabStop = true;
            this.smallRadio.Text = "Small ($7)";
            this.smallRadio.UseVisualStyleBackColor = true;
            this.smallRadio.CheckedChanged += new System.EventHandler(this.smallRadio_CheckedChanged);
            // 
            // mediumRadio
            // 
            this.mediumRadio.AutoSize = true;
            this.mediumRadio.ForeColor = System.Drawing.SystemColors.Menu;
            this.mediumRadio.Location = new System.Drawing.Point(29, 92);
            this.mediumRadio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mediumRadio.Name = "mediumRadio";
            this.mediumRadio.Size = new System.Drawing.Size(165, 28);
            this.mediumRadio.TabIndex = 10;
            this.mediumRadio.TabStop = true;
            this.mediumRadio.Text = "Medium ($9)";
            this.mediumRadio.UseVisualStyleBackColor = true;
            this.mediumRadio.CheckedChanged += new System.EventHandler(this.mediumRadio_CheckedChanged);
            // 
            // largeRadio
            // 
            this.largeRadio.AutoSize = true;
            this.largeRadio.ForeColor = System.Drawing.SystemColors.Menu;
            this.largeRadio.Location = new System.Drawing.Point(29, 135);
            this.largeRadio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.largeRadio.Name = "largeRadio";
            this.largeRadio.Size = new System.Drawing.Size(147, 28);
            this.largeRadio.TabIndex = 11;
            this.largeRadio.TabStop = true;
            this.largeRadio.Text = "Large ($12)";
            this.largeRadio.UseVisualStyleBackColor = true;
            this.largeRadio.CheckedChanged += new System.EventHandler(this.largeRadio_CheckedChanged);
            // 
            // toppingGroups
            // 
            this.toppingGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(98)))), ((int)(((byte)(77)))));
            this.toppingGroups.Controls.Add(this.label1);
            this.toppingGroups.Controls.Add(this.pepper);
            this.toppingGroups.Controls.Add(this.pineapple);
            this.toppingGroups.Controls.Add(this.bacon);
            this.toppingGroups.Controls.Add(this.mushroom);
            this.toppingGroups.Controls.Add(this.chicken);
            this.toppingGroups.Controls.Add(this.Pep);
            this.toppingGroups.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingGroups.ForeColor = System.Drawing.SystemColors.Menu;
            this.toppingGroups.Location = new System.Drawing.Point(675, 116);
            this.toppingGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toppingGroups.Name = "toppingGroups";
            this.toppingGroups.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toppingGroups.Size = new System.Drawing.Size(230, 335);
            this.toppingGroups.TabIndex = 12;
            this.toppingGroups.TabStop = false;
            this.toppingGroups.Text = "Toppings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Max 6 toppings.\r\n$1 per topping.";
            // 
            // sizeGroups
            // 
            this.sizeGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(98)))), ((int)(((byte)(77)))));
            this.sizeGroups.Controls.Add(this.largeRadio);
            this.sizeGroups.Controls.Add(this.mediumRadio);
            this.sizeGroups.Controls.Add(this.smallRadio);
            this.sizeGroups.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeGroups.ForeColor = System.Drawing.SystemColors.Menu;
            this.sizeGroups.Location = new System.Drawing.Point(400, 116);
            this.sizeGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sizeGroups.Name = "sizeGroups";
            this.sizeGroups.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sizeGroups.Size = new System.Drawing.Size(229, 195);
            this.sizeGroups.TabIndex = 14;
            this.sizeGroups.TabStop = false;
            this.sizeGroups.Text = "Pizza Sizes";
            // 
            // tipBox
            // 
            this.tipBox.BackColor = System.Drawing.SystemColors.Control;
            this.tipBox.Location = new System.Drawing.Point(141, 68);
            this.tipBox.Name = "tipBox";
            this.tipBox.Size = new System.Drawing.Size(53, 25);
            this.tipBox.TabIndex = 15;
            this.tipBox.Text = "$2.00";
            this.tipBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.BackColor = System.Drawing.Color.Transparent;
            this.tip.Location = new System.Drawing.Point(19, 71);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(118, 17);
            this.tip.TabIndex = 16;
            this.tip.Text = "Driver Tip . . ";
            // 
            // Totals
            // 
            this.Totals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(98)))), ((int)(((byte)(77)))));
            this.Totals.Controls.Add(this.total);
            this.Totals.Controls.Add(this.tax3);
            this.Totals.Controls.Add(this.order);
            this.Totals.Controls.Add(this.label3);
            this.Totals.Controls.Add(this.label2);
            this.Totals.Controls.Add(this.tip);
            this.Totals.Controls.Add(this.tipBox);
            this.Totals.Controls.Add(this.mattlabel);
            this.Totals.Controls.Add(this.orderButton);
            this.Totals.ForeColor = System.Drawing.SystemColors.Menu;
            this.Totals.Location = new System.Drawing.Point(400, 377);
            this.Totals.Name = "Totals";
            this.Totals.Size = new System.Drawing.Size(229, 201);
            this.Totals.TabIndex = 17;
            this.Totals.TabStop = false;
            this.Totals.Text = "Totals";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.BackColor = System.Drawing.Color.Transparent;
            this.total.Location = new System.Drawing.Point(146, 125);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(51, 17);
            this.total.TabIndex = 18;
            this.total.Text = "$0.00";
            // 
            // tax3
            // 
            this.tax3.AutoSize = true;
            this.tax3.Location = new System.Drawing.Point(175, 99);
            this.tax3.Name = "tax3";
            this.tax3.Size = new System.Drawing.Size(28, 17);
            this.tax3.TabIndex = 21;
            this.tax3.Text = "6%";
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.Location = new System.Drawing.Point(146, 44);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(51, 17);
            this.order.TabIndex = 20;
            this.order.Text = "$0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Order . . . . . . . .";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(19, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tax . . . . . . . . . . . . . .";
            // 
            // pizzaPalace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(138)))), ((int)(((byte)(123)))));
            this.BackgroundImage = global::HW1PizzaPalace.Properties.Resources.Board_BG;
            this.ClientSize = new System.Drawing.Size(957, 607);
            this.Controls.Add(this.Totals);
            this.Controls.Add(this.sizeGroups);
            this.Controls.Add(this.toppingGroups);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "pizzaPalace";
            this.Text = "Pizza Palace";
            this.Load += new System.EventHandler(this.pizzaPalace_Load);
            this.toppingGroups.ResumeLayout(false);
            this.toppingGroups.PerformLayout();
            this.sizeGroups.ResumeLayout(false);
            this.sizeGroups.PerformLayout();
            this.Totals.ResumeLayout(false);
            this.Totals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label mattlabel;
        private System.Windows.Forms.CheckBox Pep;
        private System.Windows.Forms.CheckBox chicken;
        private System.Windows.Forms.CheckBox mushroom;
        private System.Windows.Forms.CheckBox bacon;
        private System.Windows.Forms.CheckBox pineapple;
        private System.Windows.Forms.CheckBox pepper;
        private System.Windows.Forms.RadioButton smallRadio;
        private System.Windows.Forms.RadioButton mediumRadio;
        private System.Windows.Forms.RadioButton largeRadio;
        private System.Windows.Forms.GroupBox toppingGroups;
        private System.Windows.Forms.GroupBox sizeGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tipBox;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.GroupBox Totals;
        private System.Windows.Forms.Label tax3;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label total;
    }
}

