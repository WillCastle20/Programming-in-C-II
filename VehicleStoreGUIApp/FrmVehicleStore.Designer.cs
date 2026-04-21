namespace VehicleStoreGUIApp
{
    partial class FrmVehicleStore
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
            groupBox1 = new GroupBox();
            btnCreate = new Button();
            txtWheels = new TextBox();
            txtPrice = new TextBox();
            txtYear = new TextBox();
            txtModel = new TextBox();
            txtMake = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rdoPickup = new RadioButton();
            rdoVehicle = new RadioButton();
            rdoMotorcycle = new RadioButton();
            rdoCar = new RadioButton();
            groupBox2 = new GroupBox();
            txtSpecialtyDecimal = new TextBox();
            rdoSpecialtyNo = new RadioButton();
            rdoSpecialtyYes = new RadioButton();
            lblSpecialtyDecimal = new Label();
            lblSpecialtyBoolean = new Label();
            groupBox3 = new GroupBox();
            btnAddToCart = new Button();
            lstInventory = new ListBox();
            groupBox4 = new GroupBox();
            lblTotal = new Label();
            label8 = new Label();
            btnCheckout = new Button();
            lstShoppingCart = new ListBox();
            lblVehicleTypeError = new Label();
            lblMakeError = new Label();
            lblModelError = new Label();
            lblYearError = new Label();
            lblPriceError = new Label();
            lblWheelsError = new Label();
            lblSpecialtyBooleanError = new Label();
            lblSpecialtyDecimalError = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            cmbSort = new ComboBox();
            btnSort = new Button();
            btnSaveInventory = new Button();
            btnLoadInventory = new Button();
            btnRemoveFromCart = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(txtWheels);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtYear);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(txtMake);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rdoPickup);
            groupBox1.Controls.Add(rdoVehicle);
            groupBox1.Controls.Add(rdoMotorcycle);
            groupBox1.Controls.Add(rdoCar);
            groupBox1.Location = new Point(38, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(661, 269);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create a Vehicle";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(400, 45);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 15;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += BtnCreateClickEH;
            // 
            // txtWheels
            // 
            txtWheels.Location = new Point(212, 196);
            txtWheels.Name = "txtWheels";
            txtWheels.Size = new Size(150, 31);
            txtWheels.TabIndex = 14;
            txtWheels.Leave += TxtWheelsLeaveEH;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(193, 163);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 31);
            txtPrice.TabIndex = 13;
            txtPrice.Leave += TxtPriceLeaveEH;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(212, 126);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(150, 31);
            txtYear.TabIndex = 11;
            txtYear.Leave += TxtYearLeaveEH;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(228, 88);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(150, 31);
            txtModel.TabIndex = 10;
            txtModel.Leave += TxtModelLeaveEH;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(181, 45);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(150, 31);
            txtMake.TabIndex = 9;
            txtMake.Leave += TxtMakeLeaveEH;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(133, 197);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 8;
            label5.Text = "Wheels:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 160);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 7;
            label4.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 125);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 6;
            label3.Text = "Year:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 88);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 5;
            label2.Text = "Model:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 51);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 4;
            label1.Text = "Make:";
            // 
            // rdoPickup
            // 
            rdoPickup.AutoSize = true;
            rdoPickup.Location = new Point(24, 121);
            rdoPickup.Name = "rdoPickup";
            rdoPickup.Size = new Size(89, 29);
            rdoPickup.TabIndex = 3;
            rdoPickup.TabStop = true;
            rdoPickup.Text = "Pickup";
            rdoPickup.UseVisualStyleBackColor = true;
            rdoPickup.Click += RdoPickupClickEH;
            // 
            // rdoVehicle
            // 
            rdoVehicle.AutoSize = true;
            rdoVehicle.Location = new Point(24, 156);
            rdoVehicle.Name = "rdoVehicle";
            rdoVehicle.Size = new Size(91, 29);
            rdoVehicle.TabIndex = 2;
            rdoVehicle.TabStop = true;
            rdoVehicle.Text = "Vehicle";
            rdoVehicle.UseVisualStyleBackColor = true;
            rdoVehicle.Click += RdoVehicleClickEH;
            // 
            // rdoMotorcycle
            // 
            rdoMotorcycle.AutoSize = true;
            rdoMotorcycle.Location = new Point(24, 84);
            rdoMotorcycle.Name = "rdoMotorcycle";
            rdoMotorcycle.Size = new Size(125, 29);
            rdoMotorcycle.TabIndex = 1;
            rdoMotorcycle.TabStop = true;
            rdoMotorcycle.Text = "Motorcycle";
            rdoMotorcycle.UseVisualStyleBackColor = true;
            rdoMotorcycle.Click += RdoMotorcycleClickEH;
            // 
            // rdoCar
            // 
            rdoCar.AutoSize = true;
            rdoCar.Location = new Point(24, 51);
            rdoCar.Name = "rdoCar";
            rdoCar.Size = new Size(63, 29);
            rdoCar.TabIndex = 0;
            rdoCar.TabStop = true;
            rdoCar.Text = "Car";
            rdoCar.UseVisualStyleBackColor = true;
            rdoCar.Click += RdoCarClickEH;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSpecialtyDecimal);
            groupBox2.Controls.Add(rdoSpecialtyNo);
            groupBox2.Controls.Add(rdoSpecialtyYes);
            groupBox2.Controls.Add(lblSpecialtyDecimal);
            groupBox2.Controls.Add(lblSpecialtyBoolean);
            groupBox2.Location = new Point(744, 102);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(560, 269);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Specialty Properties";
            // 
            // txtSpecialtyDecimal
            // 
            txtSpecialtyDecimal.Location = new Point(292, 57);
            txtSpecialtyDecimal.Name = "txtSpecialtyDecimal";
            txtSpecialtyDecimal.Size = new Size(150, 31);
            txtSpecialtyDecimal.TabIndex = 4;
            txtSpecialtyDecimal.Leave += TxtSpecialtyDecimalLeaveEH;
            // 
            // rdoSpecialtyNo
            // 
            rdoSpecialtyNo.AutoSize = true;
            rdoSpecialtyNo.Location = new Point(193, 100);
            rdoSpecialtyNo.Name = "rdoSpecialtyNo";
            rdoSpecialtyNo.Size = new Size(61, 29);
            rdoSpecialtyNo.TabIndex = 3;
            rdoSpecialtyNo.TabStop = true;
            rdoSpecialtyNo.Text = "No";
            rdoSpecialtyNo.UseVisualStyleBackColor = true;
            rdoSpecialtyNo.Click += RdoSpecialtyBooleanClickEH;
            // 
            // rdoSpecialtyYes
            // 
            rdoSpecialtyYes.AutoSize = true;
            rdoSpecialtyYes.Location = new Point(193, 57);
            rdoSpecialtyYes.Name = "rdoSpecialtyYes";
            rdoSpecialtyYes.Size = new Size(62, 29);
            rdoSpecialtyYes.TabIndex = 2;
            rdoSpecialtyYes.TabStop = true;
            rdoSpecialtyYes.Text = "Yes";
            rdoSpecialtyYes.UseVisualStyleBackColor = true;
            rdoSpecialtyYes.Click += RdoSpecialtyBooleanClickEH;
            // 
            // lblSpecialtyDecimal
            // 
            lblSpecialtyDecimal.AutoSize = true;
            lblSpecialtyDecimal.Location = new Point(37, 102);
            lblSpecialtyDecimal.Name = "lblSpecialtyDecimal";
            lblSpecialtyDecimal.Size = new Size(154, 25);
            lblSpecialtyDecimal.TabIndex = 1;
            lblSpecialtyDecimal.Text = "Specialty Decimal:";
            // 
            // lblSpecialtyBoolean
            // 
            lblSpecialtyBoolean.AutoSize = true;
            lblSpecialtyBoolean.Location = new Point(32, 59);
            lblSpecialtyBoolean.Name = "lblSpecialtyBoolean";
            lblSpecialtyBoolean.Size = new Size(155, 25);
            lblSpecialtyBoolean.TabIndex = 0;
            lblSpecialtyBoolean.Text = "Specialty Boolean:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLoadInventory);
            groupBox3.Controls.Add(btnSaveInventory);
            groupBox3.Controls.Add(btnSort);
            groupBox3.Controls.Add(cmbSort);
            groupBox3.Controls.Add(btnSearch);
            groupBox3.Controls.Add(txtSearch);
            groupBox3.Controls.Add(btnAddToCart);
            groupBox3.Controls.Add(lstInventory);
            groupBox3.Location = new Point(58, 441);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(641, 220);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Store Inventory";
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(71, 45);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(112, 34);
            btnAddToCart.TabIndex = 1;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += BtnAddToCartClickEH;
            // 
            // lstInventory
            // 
            lstInventory.FormattingEnabled = true;
            lstInventory.ItemHeight = 25;
            lstInventory.Location = new Point(41, 85);
            lstInventory.Name = "lstInventory";
            lstInventory.Size = new Size(180, 129);
            lstInventory.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnRemoveFromCart);
            groupBox4.Controls.Add(lblTotal);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(btnCheckout);
            groupBox4.Controls.Add(lstShoppingCart);
            groupBox4.Location = new Point(752, 441);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(561, 220);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Shopping Cart";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(312, 91);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 25);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "$0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(238, 91);
            label8.Name = "label8";
            label8.Size = new Size(53, 25);
            label8.TabIndex = 2;
            label8.Text = "Total:";
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(238, 30);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(112, 34);
            btnCheckout.TabIndex = 1;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += BtnCheckoutClickEH;
            // 
            // lstShoppingCart
            // 
            lstShoppingCart.FormattingEnabled = true;
            lstShoppingCart.ItemHeight = 25;
            lstShoppingCart.Location = new Point(29, 39);
            lstShoppingCart.Name = "lstShoppingCart";
            lstShoppingCart.Size = new Size(180, 129);
            lstShoppingCart.TabIndex = 0;
            // 
            // lblVehicleTypeError
            // 
            lblVehicleTypeError.AutoSize = true;
            lblVehicleTypeError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehicleTypeError.ForeColor = Color.Red;
            lblVehicleTypeError.Location = new Point(25, 395);
            lblVehicleTypeError.Name = "lblVehicleTypeError";
            lblVehicleTypeError.Size = new Size(254, 25);
            lblVehicleTypeError.TabIndex = 4;
            lblVehicleTypeError.Text = "Please choose a vehicle type";
            // 
            // lblMakeError
            // 
            lblMakeError.AutoSize = true;
            lblMakeError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMakeError.ForeColor = Color.Red;
            lblMakeError.Location = new Point(286, 395);
            lblMakeError.Name = "lblMakeError";
            lblMakeError.Size = new Size(182, 25);
            lblMakeError.TabIndex = 5;
            lblMakeError.Text = "Please enter a make";
            // 
            // lblModelError
            // 
            lblModelError.AutoSize = true;
            lblModelError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModelError.ForeColor = Color.Red;
            lblModelError.Location = new Point(460, 374);
            lblModelError.Name = "lblModelError";
            lblModelError.Size = new Size(189, 25);
            lblModelError.TabIndex = 6;
            lblModelError.Text = "Please enter a model";
            // 
            // lblYearError
            // 
            lblYearError.AutoSize = true;
            lblYearError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYearError.ForeColor = Color.Red;
            lblYearError.Location = new Point(549, 413);
            lblYearError.Name = "lblYearError";
            lblYearError.Size = new Size(219, 25);
            lblYearError.TabIndex = 7;
            lblYearError.Text = "Please enter a valid year";
            // 
            // lblPriceError
            // 
            lblPriceError.AutoSize = true;
            lblPriceError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceError.ForeColor = Color.Red;
            lblPriceError.Location = new Point(831, 413);
            lblPriceError.Name = "lblPriceError";
            lblPriceError.Size = new Size(224, 25);
            lblPriceError.TabIndex = 8;
            lblPriceError.Text = "Please enter a valid price";
            // 
            // lblWheelsError
            // 
            lblWheelsError.AutoSize = true;
            lblWheelsError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWheelsError.ForeColor = Color.Red;
            lblWheelsError.Location = new Point(701, 374);
            lblWheelsError.Name = "lblWheelsError";
            lblWheelsError.Size = new Size(334, 25);
            lblWheelsError.TabIndex = 9;
            lblWheelsError.Text = "Please enter a valid number of wheels";
            // 
            // lblSpecialtyBooleanError
            // 
            lblSpecialtyBooleanError.AutoSize = true;
            lblSpecialtyBooleanError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpecialtyBooleanError.ForeColor = Color.Red;
            lblSpecialtyBooleanError.Location = new Point(1064, 413);
            lblSpecialtyBooleanError.Name = "lblSpecialtyBooleanError";
            lblSpecialtyBooleanError.Size = new Size(216, 25);
            lblSpecialtyBooleanError.TabIndex = 10;
            lblSpecialtyBooleanError.Text = "Please choose Yes or No";
            // 
            // lblSpecialtyDecimalError
            // 
            lblSpecialtyDecimalError.AutoSize = true;
            lblSpecialtyDecimalError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpecialtyDecimalError.ForeColor = Color.Red;
            lblSpecialtyDecimalError.Location = new Point(1036, 374);
            lblSpecialtyDecimalError.Name = "lblSpecialtyDecimalError";
            lblSpecialtyDecimalError.Size = new Size(308, 25);
            lblSpecialtyDecimalError.TabIndex = 11;
            lblSpecialtyDecimalError.Text = "Please enter a valid specialty value";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(470, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 31);
            txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(352, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbSort
            // 
            cmbSort.FormattingEnabled = true;
            cmbSort.Location = new Point(453, 85);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(182, 33);
            cmbSort.TabIndex = 18;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(320, 83);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(112, 34);
            btnSort.TabIndex = 19;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            // 
            // btnSaveInventory
            // 
            btnSaveInventory.Location = new Point(315, 157);
            btnSaveInventory.Name = "btnSaveInventory";
            btnSaveInventory.Size = new Size(112, 34);
            btnSaveInventory.TabIndex = 20;
            btnSaveInventory.Text = "Save Inventory";
            btnSaveInventory.UseVisualStyleBackColor = true;
            // 
            // btnLoadInventory
            // 
            btnLoadInventory.Location = new Point(461, 164);
            btnLoadInventory.Name = "btnLoadInventory";
            btnLoadInventory.Size = new Size(112, 34);
            btnLoadInventory.TabIndex = 21;
            btnLoadInventory.Text = "Load";
            btnLoadInventory.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.Location = new Point(403, 161);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(112, 34);
            btnRemoveFromCart.TabIndex = 4;
            btnRemoveFromCart.Text = "Remove From Cart";
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            // 
            // FrmVehicleStore
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 694);
            Controls.Add(lblSpecialtyDecimalError);
            Controls.Add(lblSpecialtyBooleanError);
            Controls.Add(lblWheelsError);
            Controls.Add(lblPriceError);
            Controls.Add(lblYearError);
            Controls.Add(lblModelError);
            Controls.Add(lblMakeError);
            Controls.Add(lblVehicleTypeError);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmVehicleStore";
            Text = "Vehicle Store";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton rdoPickup;
        private RadioButton rdoVehicle;
        private RadioButton rdoMotorcycle;
        private RadioButton rdoCar;
        private TextBox txtWheels;
        private TextBox txtPrice;
        private TextBox txtYear;
        private TextBox txtModel;
        private TextBox txtMake;
        private Label label5;
        private Button btnCreate;
        private GroupBox groupBox2;
        private TextBox txtSpecialtyDecimal;
        private RadioButton rdoSpecialtyNo;
        private RadioButton rdoSpecialtyYes;
        private Label lblSpecialtyDecimal;
        private Label lblSpecialtyBoolean;
        private GroupBox groupBox3;
        private Button btnAddToCart;
        private ListBox lstInventory;
        private GroupBox groupBox4;
        private Label lblTotal;
        private Label label8;
        private Button btnCheckout;
        private ListBox lstShoppingCart;
        private Label lblVehicleTypeError;
        private Label lblMakeError;
        private Label lblModelError;
        private Label lblYearError;
        private Label lblPriceError;
        private Label lblWheelsError;
        private Label lblSpecialtyBooleanError;
        private Label lblSpecialtyDecimalError;
        private Button btnSort;
        private ComboBox cmbSort;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnLoadInventory;
        private Button btnSaveInventory;
        private Button btnRemoveFromCart;
    }
}
