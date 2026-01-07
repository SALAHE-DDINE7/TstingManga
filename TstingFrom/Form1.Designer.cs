namespace TstingFrom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            searchlabel = new Label();
            datalabel = new Label();
            quanitylabel = new Label();
            idlabel = new Label();
            pricelabel = new Label();
            namelabel = new Label();
            searchtextBox = new TextBox();
            idtextBox = new TextBox();
            quantitytextBox = new TextBox();
            nametextBox = new TextBox();
            pricetextBox = new TextBox();
            dataGridView = new DataGridView();
            button1 = new Button();
            Addbutton = new Button();
            updatebutton = new Button();
            Deletebutton = new Button();
            loadatabutton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // searchlabel
            // 
            searchlabel.AutoSize = true;
            searchlabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchlabel.Location = new Point(77, 69);
            searchlabel.Name = "searchlabel";
            searchlabel.Size = new Size(82, 30);
            searchlabel.TabIndex = 0;
            searchlabel.Text = "Search";
            // 
            // datalabel
            // 
            datalabel.AutoSize = true;
            datalabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datalabel.Location = new Point(398, 348);
            datalabel.Name = "datalabel";
            datalabel.Size = new Size(62, 30);
            datalabel.TabIndex = 1;
            datalabel.Text = "Data";
            // 
            // quanitylabel
            // 
            quanitylabel.AutoSize = true;
            quanitylabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quanitylabel.Location = new Point(429, 157);
            quanitylabel.Name = "quanitylabel";
            quanitylabel.Size = new Size(104, 30);
            quanitylabel.TabIndex = 2;
            quanitylabel.Text = "Quantity";
            // 
            // idlabel
            // 
            idlabel.AutoSize = true;
            idlabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idlabel.Location = new Point(77, 157);
            idlabel.Name = "idlabel";
            idlabel.Size = new Size(34, 30);
            idlabel.TabIndex = 3;
            idlabel.Text = "Id";
            // 
            // pricelabel
            // 
            pricelabel.AutoSize = true;
            pricelabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pricelabel.Location = new Point(429, 260);
            pricelabel.Name = "pricelabel";
            pricelabel.Size = new Size(65, 30);
            pricelabel.TabIndex = 4;
            pricelabel.Text = "Price";
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namelabel.Location = new Point(77, 260);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(74, 30);
            namelabel.TabIndex = 5;
            namelabel.Text = "Name";
            // 
            // searchtextBox
            // 
            searchtextBox.Location = new Point(192, 68);
            searchtextBox.Name = "searchtextBox";
            searchtextBox.Size = new Size(477, 31);
            searchtextBox.TabIndex = 6;
            // 
            // idtextBox
            // 
            idtextBox.Location = new Point(147, 156);
            idtextBox.Name = "idtextBox";
            idtextBox.Size = new Size(213, 31);
            idtextBox.TabIndex = 7;
            // 
            // quantitytextBox
            // 
            quantitytextBox.Location = new Point(571, 156);
            quantitytextBox.Name = "quantitytextBox";
            quantitytextBox.Size = new Size(213, 31);
            quantitytextBox.TabIndex = 8;
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(147, 261);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(213, 31);
            nametextBox.TabIndex = 9;
            // 
            // pricetextBox
            // 
            pricetextBox.Location = new Point(571, 259);
            pricetextBox.Name = "pricetextBox";
            pricetextBox.Size = new Size(213, 31);
            pricetextBox.TabIndex = 10;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(43, 381);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(777, 225);
            dataGridView.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(690, 65);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 12;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // Addbutton
            // 
            Addbutton.Location = new Point(43, 625);
            Addbutton.Name = "Addbutton";
            Addbutton.Size = new Size(112, 34);
            Addbutton.TabIndex = 13;
            Addbutton.Text = "Add";
            Addbutton.UseVisualStyleBackColor = true;
            // 
            // updatebutton
            // 
            updatebutton.Location = new Point(275, 625);
            updatebutton.Name = "updatebutton";
            updatebutton.Size = new Size(112, 34);
            updatebutton.TabIndex = 14;
            updatebutton.Text = "Update";
            updatebutton.UseVisualStyleBackColor = true;
            updatebutton.Click += button2_Click;
            // 
            // Deletebutton
            // 
            Deletebutton.Location = new Point(504, 625);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(112, 34);
            Deletebutton.TabIndex = 15;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = true;
            // 
            // loadatabutton
            // 
            loadatabutton.Location = new Point(708, 625);
            loadatabutton.Name = "loadatabutton";
            loadatabutton.Size = new Size(112, 34);
            loadatabutton.TabIndex = 16;
            loadatabutton.Text = "Load data";
            loadatabutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 689);
            Controls.Add(loadatabutton);
            Controls.Add(Deletebutton);
            Controls.Add(updatebutton);
            Controls.Add(Addbutton);
            Controls.Add(button1);
            Controls.Add(dataGridView);
            Controls.Add(pricetextBox);
            Controls.Add(nametextBox);
            Controls.Add(quantitytextBox);
            Controls.Add(idtextBox);
            Controls.Add(searchtextBox);
            Controls.Add(namelabel);
            Controls.Add(pricelabel);
            Controls.Add(idlabel);
            Controls.Add(quanitylabel);
            Controls.Add(datalabel);
            Controls.Add(searchlabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label searchlabel;
        private Label datalabel;
        private Label quanitylabel;
        private Label idlabel;
        private Label pricelabel;
        private Label namelabel;
        private TextBox searchtextBox;
        private TextBox idtextBox;
        private TextBox quantitytextBox;
        private TextBox nametextBox;
        private TextBox pricetextBox;
        private DataGridView dataGridView;
        private Button button1;
        private Button Addbutton;
        private Button updatebutton;
        private Button Deletebutton;
        private Button loadatabutton;
    }
}
