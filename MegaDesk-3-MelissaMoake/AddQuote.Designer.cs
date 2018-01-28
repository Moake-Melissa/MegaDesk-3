namespace MegaDesk_3_MelissaMoake
{
    partial class AddQuote
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
            this.cancelQuoteButton = new System.Windows.Forms.Button();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.numOfDrawersLabel = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.widthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.depthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.depth = new System.Windows.Forms.TextBox();
            this.materialLabel = new System.Windows.Forms.Label();
            this.materialType = new System.Windows.Forms.ComboBox();
            this.numOfDrawers = new System.Windows.Forms.TextBox();
            this.widthError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rushOptions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelQuoteButton
            // 
            this.cancelQuoteButton.AutoSize = true;
            this.cancelQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelQuoteButton.Location = new System.Drawing.Point(306, 252);
            this.cancelQuoteButton.Name = "cancelQuoteButton";
            this.cancelQuoteButton.Size = new System.Drawing.Size(75, 27);
            this.cancelQuoteButton.TabIndex = 0;
            this.cancelQuoteButton.Text = "Cancel";
            this.cancelQuoteButton.UseVisualStyleBackColor = true;
            this.cancelQuoteButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cancelQuoteButton_Click);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(31, 29);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(49, 17);
            this.customerNameLabel.TabIndex = 1;
            this.customerNameLabel.Text = "Name:";
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(178, 28);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(187, 20);
            this.customerName.TabIndex = 2;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(31, 65);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(139, 17);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Desk Width (inches):";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(31, 103);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(141, 17);
            this.depthLabel.TabIndex = 5;
            this.depthLabel.Text = "Desk Depth (inches):";
            // 
            // numOfDrawersLabel
            // 
            this.numOfDrawersLabel.AutoSize = true;
            this.numOfDrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfDrawersLabel.Location = new System.Drawing.Point(31, 139);
            this.numOfDrawersLabel.Name = "numOfDrawersLabel";
            this.numOfDrawersLabel.Size = new System.Drawing.Size(134, 17);
            this.numOfDrawersLabel.TabIndex = 7;
            this.numOfDrawersLabel.Text = "Number of Drawers:";
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(178, 65);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(54, 20);
            this.width.TabIndex = 8;
            this.width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.widthCharValidation);
            this.width.Validating += new System.ComponentModel.CancelEventHandler(this.width_Validating);
            this.width.Validated += new System.EventHandler(this.width_Validated);
            // 
            // widthErrorProvider
            // 
            this.widthErrorProvider.ContainerControl = this;
            // 
            // depthErrorProvider
            // 
            this.depthErrorProvider.ContainerControl = this;
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(178, 102);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(54, 20);
            this.depth.TabIndex = 9;
            this.depth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthCharValidation);
            this.depth.Validating += new System.ComponentModel.CancelEventHandler(this.depth_Validating);
            this.depth.Validated += new System.EventHandler(this.depth_Validated);
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.Location = new System.Drawing.Point(31, 177);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(98, 17);
            this.materialLabel.TabIndex = 11;
            this.materialLabel.Text = "Desk Material:";
            // 
            // materialType
            // 
            this.materialType.FormattingEnabled = true;
            this.materialType.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.materialType.Location = new System.Drawing.Point(178, 177);
            this.materialType.MaxDropDownItems = 5;
            this.materialType.Name = "materialType";
            this.materialType.Size = new System.Drawing.Size(121, 21);
            this.materialType.TabIndex = 12;
            this.materialType.Text = "Select an option...";
            // 
            // numOfDrawers
            // 
            this.numOfDrawers.Location = new System.Drawing.Point(178, 139);
            this.numOfDrawers.Name = "numOfDrawers";
            this.numOfDrawers.Size = new System.Drawing.Size(54, 20);
            this.numOfDrawers.TabIndex = 10;
            // 
            // widthError
            // 
            this.widthError.AutoSize = true;
            this.widthError.Location = new System.Drawing.Point(238, 67);
            this.widthError.Name = "widthError";
            this.widthError.Size = new System.Drawing.Size(0, 13);
            this.widthError.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rush Options:";
            // 
            // rushOptions
            // 
            this.rushOptions.FormattingEnabled = true;
            this.rushOptions.Items.AddRange(new object[] {
            "3 Days",
            "5 Days",
            "7 Days",
            "No Rush (14 days)"});
            this.rushOptions.Location = new System.Drawing.Point(178, 211);
            this.rushOptions.MaxDropDownItems = 5;
            this.rushOptions.Name = "rushOptions";
            this.rushOptions.Size = new System.Drawing.Size(121, 21);
            this.rushOptions.TabIndex = 15;
            this.rushOptions.Text = "Select an option...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "range: 24in - 96in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "range: 12in - 48in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "range: 0-7";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 291);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rushOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthError);
            this.Controls.Add(this.materialType);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.numOfDrawers);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.numOfDrawersLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.cancelQuoteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelQuoteButton;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label numOfDrawersLabel;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.ErrorProvider widthErrorProvider;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.ErrorProvider depthErrorProvider;
        private System.Windows.Forms.ComboBox materialType;
        private System.Windows.Forms.TextBox numOfDrawers;
        private System.Windows.Forms.Label widthError;
        private System.Windows.Forms.ComboBox rushOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}