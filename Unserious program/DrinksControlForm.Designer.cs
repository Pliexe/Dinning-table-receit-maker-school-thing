
namespace Unserious_program
{
    partial class DrinksControlForm
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
            this.addItemButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.drinksListBox = new System.Windows.Forms.ListBox();
            this.removeDrinkButton = new System.Windows.Forms.Button();
            this.EditDrinkButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.sortNumSmallerToBigger = new System.Windows.Forms.Button();
            this.sortNumBiggerToSmaller = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(202, 12);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 0;
            this.addItemButton.Text = "Add";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(213, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(294, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // drinksListBox
            // 
            this.drinksListBox.FormattingEnabled = true;
            this.drinksListBox.ItemHeight = 15;
            this.drinksListBox.Location = new System.Drawing.Point(12, 12);
            this.drinksListBox.Name = "drinksListBox";
            this.drinksListBox.Size = new System.Drawing.Size(184, 394);
            this.drinksListBox.TabIndex = 3;
            // 
            // removeDrinkButton
            // 
            this.removeDrinkButton.Location = new System.Drawing.Point(247, 41);
            this.removeDrinkButton.Name = "removeDrinkButton";
            this.removeDrinkButton.Size = new System.Drawing.Size(75, 23);
            this.removeDrinkButton.TabIndex = 4;
            this.removeDrinkButton.Text = "Remove";
            this.removeDrinkButton.UseVisualStyleBackColor = true;
            this.removeDrinkButton.Click += new System.EventHandler(this.RemoveDrinkButton_Click);
            // 
            // EditDrinkButton
            // 
            this.EditDrinkButton.Location = new System.Drawing.Point(294, 12);
            this.EditDrinkButton.Name = "EditDrinkButton";
            this.EditDrinkButton.Size = new System.Drawing.Size(75, 23);
            this.EditDrinkButton.TabIndex = 5;
            this.EditDrinkButton.Text = "Edit";
            this.EditDrinkButton.UseVisualStyleBackColor = true;
            this.EditDrinkButton.Click += new System.EventHandler(this.EditDrinkButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.moveUpButton);
            this.groupBox1.Controls.Add(this.moveDownButton);
            this.groupBox1.Controls.Add(this.sortNumSmallerToBigger);
            this.groupBox1.Controls.Add(this.sortNumBiggerToSmaller);
            this.groupBox1.Location = new System.Drawing.Point(202, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 143);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szortirozás";
            // 
            // moveUpButton
            // 
            this.moveUpButton.Location = new System.Drawing.Point(86, 97);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(75, 23);
            this.moveUpButton.TabIndex = 3;
            this.moveUpButton.Text = "Fel";
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // moveDownButton
            // 
            this.moveDownButton.Location = new System.Drawing.Point(6, 97);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(75, 23);
            this.moveDownButton.TabIndex = 2;
            this.moveDownButton.Text = "Le";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // sortNumSmallerToBigger
            // 
            this.sortNumSmallerToBigger.Location = new System.Drawing.Point(86, 22);
            this.sortNumSmallerToBigger.Name = "sortNumSmallerToBigger";
            this.sortNumSmallerToBigger.Size = new System.Drawing.Size(75, 23);
            this.sortNumSmallerToBigger.TabIndex = 1;
            this.sortNumSmallerToBigger.Text = "Ár 2<1";
            this.sortNumSmallerToBigger.UseVisualStyleBackColor = true;
            this.sortNumSmallerToBigger.Click += new System.EventHandler(this.SortNumSmallerToBigger_Click);
            // 
            // sortNumBiggerToSmaller
            // 
            this.sortNumBiggerToSmaller.Location = new System.Drawing.Point(6, 22);
            this.sortNumBiggerToSmaller.Name = "sortNumBiggerToSmaller";
            this.sortNumBiggerToSmaller.Size = new System.Drawing.Size(75, 23);
            this.sortNumBiggerToSmaller.TabIndex = 0;
            this.sortNumBiggerToSmaller.Text = "Ár 2>1";
            this.sortNumBiggerToSmaller.UseVisualStyleBackColor = true;
            this.sortNumBiggerToSmaller.Click += new System.EventHandler(this.SortNumBiggerToSmaller_Click);
            // 
            // DrinksControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EditDrinkButton);
            this.Controls.Add(this.removeDrinkButton);
            this.Controls.Add(this.drinksListBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addItemButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DrinksControlForm";
            this.Text = "DrinksControlForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox drinksListBox;
        private System.Windows.Forms.Button removeDrinkButton;
        private System.Windows.Forms.Button EditDrinkButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sortNumBiggerToSmaller;
        private System.Windows.Forms.Button sortNumSmallerToBigger;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Button moveDownButton;
    }
}