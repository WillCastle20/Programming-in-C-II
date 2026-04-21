/*
 * William Castellanos
 * CST-250
 * Activity 1
 * 4/20/2026
 * Citation: Grand Canyon University CST-250 Activity 1 Guide
 */

using System;
using System.ComponentModel;
using System.Windows.Forms;
using VehicleClassLibrary.Models;
using VehicleClassLibrary.Services.BusinessLogicLayer;
using System.Linq;

namespace VehicleStoreGUIApp
{
    public partial class FrmVehicleStore : Form
    {
        private string currentVehicleType;
        private bool isVehicleTypeValid;
        private bool isMakeValid;
        private bool isModelValid;
        private bool isYearValid;
        private bool isPriceValid;
        private bool isWheelsValid;
        private bool isSpecialtyBooleanValid;
        private bool isSpecialtyDecimalValid;

        private StoreLogic _storeLogic;
        private BindingSource _inventoryBindingSource;
        private BindingSource _shoppingCartBindingSource;

        /// <summary>
        /// Initializes the Vehicle Store form.
        /// </summary>
        public FrmVehicleStore()
        {
            InitializeComponent();

            currentVehicleType = string.Empty;

            isVehicleTypeValid = false;
            isMakeValid = false;
            isModelValid = false;
            isYearValid = false;
            isPriceValid = false;
            isWheelsValid = false;
            isSpecialtyBooleanValid = false;
            isSpecialtyDecimalValid = false;

            _storeLogic = new StoreLogic();

            _inventoryBindingSource = new BindingSource();
            _shoppingCartBindingSource = new BindingSource();

            _inventoryBindingSource.DataSource = _storeLogic.GetInventory();
            _shoppingCartBindingSource.DataSource = _storeLogic.GetShoppingCart();

            lstInventory.DataSource = _inventoryBindingSource;
            lstShoppingCart.DataSource = _shoppingCartBindingSource;

            lblVehicleTypeError.Visible = false;
            lblMakeError.Visible = false;
            lblModelError.Visible = false;
            lblYearError.Visible = false;
            lblPriceError.Visible = false;
            lblWheelsError.Visible = false;
            lblSpecialtyBooleanError.Visible = false;
            lblSpecialtyDecimalError.Visible = false;

            lblSpecialtyBoolean.Visible = false;
            lblSpecialtyDecimal.Visible = false;
            rdoSpecialtyYes.Visible = false;
            rdoSpecialtyNo.Visible = false;
            txtSpecialtyDecimal.Visible = false;

            cmbSort.Items.Add("Make");
            cmbSort.Items.Add("Model");
            cmbSort.Items.Add("Year");
            cmbSort.Items.Add("Price");
            cmbSort.SelectedIndex = 0;
        }

        /// <summary>
        /// Updates the specialty controls for a car.
        /// </summary>
        private void RdoCarClickEH(object sender, EventArgs e)
        {
            currentVehicleType = "Car";
            lblSpecialtyBoolean.Text = "Convertible:";
            lblSpecialtyDecimal.Text = "Trunk Size:";
            ShowSpecialtyControls();
            ValidateVehicleType();
        }

        /// <summary>
        /// Updates the specialty controls for a motorcycle.
        /// </summary>
        private void RdoMotorcycleClickEH(object sender, EventArgs e)
        {
            currentVehicleType = "Motorcycle";
            lblSpecialtyBoolean.Text = "Has Side Car:";
            lblSpecialtyDecimal.Text = "Seat Height:";
            ShowSpecialtyControls();
            ValidateVehicleType();
        }

        /// <summary>
        /// Updates the specialty controls for a pickup.
        /// </summary>
        private void RdoPickupClickEH(object sender, EventArgs e)
        {
            currentVehicleType = "Pickup";
            lblSpecialtyBoolean.Text = "Has Bed Cover:";
            lblSpecialtyDecimal.Text = "Bed Size:";
            ShowSpecialtyControls();
            ValidateVehicleType();
        }

        /// <summary>
        /// Hides specialty controls for a standard vehicle.
        /// </summary>
        private void RdoVehicleClickEH(object sender, EventArgs e)
        {
            currentVehicleType = "Vehicle";

            lblSpecialtyBoolean.Visible = false;
            lblSpecialtyDecimal.Visible = false;
            rdoSpecialtyYes.Visible = false;
            rdoSpecialtyNo.Visible = false;
            txtSpecialtyDecimal.Visible = false;
            lblSpecialtyBooleanError.Visible = false;
            lblSpecialtyDecimalError.Visible = false;

            ValidateVehicleType();
        }

        /// <summary>
        /// Shows the specialty controls.
        /// </summary>
        private void ShowSpecialtyControls()
        {
            lblSpecialtyBoolean.Visible = true;
            lblSpecialtyDecimal.Visible = true;
            rdoSpecialtyYes.Visible = true;
            rdoSpecialtyNo.Visible = true;
            txtSpecialtyDecimal.Visible = true;
        }

        /// <summary>
        /// Creates a vehicle from validated input and adds it to inventory.
        /// </summary>
        private void BtnCreateClickEH(object sender, EventArgs e)
        {
            string make = ValidateTxtMake();
            string model = ValidateTxtModel();
            int year = ValidateTxtYear();
            decimal price = ValidateTxtPrice();
            int wheels = ValidateTxtWheels();
            bool specialtyBoolean = ValidateSpecialtyBoolean();
            decimal specialtyDecimal = ValidateSpecialtyDecimal();

            VehicleModel vehicle = null;

            if (isVehicleTypeValid && isMakeValid && isModelValid && isYearValid &&
                isPriceValid && isWheelsValid && isSpecialtyBooleanValid && isSpecialtyDecimalValid)
            {
                switch (currentVehicleType)
                {
                    case "Car":
                        vehicle = new CarModel(0, make, model, year, price, wheels, specialtyBoolean, specialtyDecimal);
                        break;

                    case "Motorcycle":
                        vehicle = new MotorcycleModel(0, make, model, year, price, wheels, specialtyBoolean, specialtyDecimal);
                        break;

                    case "Pickup":
                        vehicle = new PickupModel(0, make, model, year, price, wheels, specialtyBoolean, specialtyDecimal);
                        break;

                    case "Vehicle":
                        vehicle = new VehicleModel(0, make, model, year, price, wheels);
                        break;
                }

                if (vehicle != null)
                {
                    _storeLogic.AddVehicleToInventory(vehicle);
                    _inventoryBindingSource.ResetBindings(false);
                    MessageBox.Show($"{vehicle} created successfully.");

                    txtMake.Clear();
                    txtModel.Clear();
                    txtYear.Clear();
                    txtPrice.Clear();
                    txtWheels.Clear();
                    txtSpecialtyDecimal.Clear();

                    rdoCar.Checked = false;
                    rdoMotorcycle.Checked = false;
                    rdoPickup.Checked = false;
                    rdoVehicle.Checked = false;
                    rdoSpecialtyYes.Checked = false;
                    rdoSpecialtyNo.Checked = false;

                    currentVehicleType = string.Empty;
                    RdoVehicleClickEH(sender, e);
                }
            }
        }

        /// <summary>
        /// Validates that a vehicle type has been selected.
        /// </summary>
        private void ValidateVehicleType()
        {
            if (!rdoCar.Checked && !rdoMotorcycle.Checked && !rdoPickup.Checked && !rdoVehicle.Checked)
            {
                lblVehicleTypeError.Visible = true;
                isVehicleTypeValid = false;
            }
            else
            {
                lblVehicleTypeError.Visible = false;
                isVehicleTypeValid = true;
            }
        }

        /// <summary>
        /// Validates the Make text box.
        /// </summary>
        private string ValidateTxtMake()
        {
            if (string.IsNullOrWhiteSpace(txtMake.Text))
            {
                lblMakeError.Visible = true;
                isMakeValid = false;
                return string.Empty;
            }

            lblMakeError.Visible = false;
            isMakeValid = true;
            return txtMake.Text.Trim();
        }

        /// <summary>
        /// Validates the Model text box.
        /// </summary>
        private string ValidateTxtModel()
        {
            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                lblModelError.Visible = true;
                isModelValid = false;
                return string.Empty;
            }

            lblModelError.Visible = false;
            isModelValid = true;
            return txtModel.Text.Trim();
        }

        /// <summary>
        /// Validates the Year text box.
        /// </summary>
        private int ValidateTxtYear()
        {
            if (!int.TryParse(txtYear.Text, out int year))
            {
                lblYearError.Visible = true;
                isYearValid = false;
                return 0;
            }

            lblYearError.Visible = false;
            isYearValid = true;
            return year;
        }

        /// <summary>
        /// Validates the Price text box.
        /// </summary>
        private decimal ValidateTxtPrice()
        {
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                lblPriceError.Visible = true;
                isPriceValid = false;
                return 0.0m;
            }

            lblPriceError.Visible = false;
            isPriceValid = true;
            return price;
        }

        /// <summary>
        /// Validates the Wheels text box.
        /// </summary>
        private int ValidateTxtWheels()
        {
            if (!int.TryParse(txtWheels.Text, out int wheels))
            {
                lblWheelsError.Visible = true;
                isWheelsValid = false;
                return 0;
            }

            lblWheelsError.Visible = false;
            isWheelsValid = true;
            return wheels;
        }

        /// <summary>
        /// Validates the specialty Boolean choice.
        /// </summary>
        private bool ValidateSpecialtyBoolean()
        {
            if (currentVehicleType == "Vehicle")
            {
                lblSpecialtyBooleanError.Visible = false;
                isSpecialtyBooleanValid = true;
                return false;
            }

            if (!rdoSpecialtyYes.Checked && !rdoSpecialtyNo.Checked)
            {
                lblSpecialtyBooleanError.Visible = true;
                isSpecialtyBooleanValid = false;
                return false;
            }

            lblSpecialtyBooleanError.Visible = false;
            isSpecialtyBooleanValid = true;
            return rdoSpecialtyYes.Checked;
        }

        /// <summary>
        /// Validates the specialty decimal text box.
        /// </summary>
        private decimal ValidateSpecialtyDecimal()
        {
            if (currentVehicleType == "Vehicle")
            {
                lblSpecialtyDecimalError.Visible = false;
                isSpecialtyDecimalValid = true;
                return 0.0m;
            }

            if (!decimal.TryParse(txtSpecialtyDecimal.Text, out decimal value))
            {
                lblSpecialtyDecimalError.Visible = true;
                isSpecialtyDecimalValid = false;
                return 0.0m;
            }

            lblSpecialtyDecimalError.Visible = false;
            isSpecialtyDecimalValid = true;
            return value;
        }

        /// <summary>
        /// Validates Make when the user leaves the text box.
        /// </summary>
        private void TxtMakeLeaveEH(object sender, EventArgs e)
        {
            ValidateTxtMake();
        }

        /// <summary>
        /// Validates Model when the user leaves the text box.
        /// </summary>
        private void TxtModelLeaveEH(object sender, EventArgs e)
        {
            ValidateTxtModel();
        }

        /// <summary>
        /// Validates Year when the user leaves the text box.
        /// </summary>
        private void TxtYearLeaveEH(object sender, EventArgs e)
        {
            ValidateTxtYear();
        }

        /// <summary>
        /// Validates Price when the user leaves the text box.
        /// </summary>
        private void TxtPriceLeaveEH(object sender, EventArgs e)
        {
            ValidateTxtPrice();
        }

        /// <summary>
        /// Validates Wheels when the user leaves the text box.
        /// </summary>
        private void TxtWheelsLeaveEH(object sender, EventArgs e)
        {
            ValidateTxtWheels();
        }

        /// <summary>
        /// Validates specialty decimal when the user leaves the text box.
        /// </summary>
        private void TxtSpecialtyDecimalLeaveEH(object sender, EventArgs e)
        {
            ValidateSpecialtyDecimal();
        }

        /// <summary>
        /// Validates specialty Boolean selection when clicked.
        /// </summary>
        private void RdoSpecialtyBooleanClickEH(object sender, EventArgs e)
        {
            ValidateSpecialtyBoolean();
        }

        /// <summary>
        /// Adds the selected inventory item to the shopping cart.
        /// </summary>
        private void BtnAddToCartClickEH(object sender, EventArgs e)
        {
            if (lstInventory.SelectedItem is VehicleModel selectedVehicle)
            {
                _storeLogic.AddVehicleToCart(selectedVehicle.Id);
                _shoppingCartBindingSource.ResetBindings(false);
            }
        }

        /// <summary>
        /// Checks out the shopping cart and updates the total label.
        /// </summary>
        private void BtnCheckoutClickEH(object sender, EventArgs e)
        {
            decimal total = _storeLogic.Checkout();
            lblTotal.Text = total.ToString("C");
            _shoppingCartBindingSource.ResetBindings(false);
        }

        /// <summary>
        /// Saves the current inventory to a text file.
        /// </summary>
        private void BtnSaveInventoryClickEH(object sender, EventArgs e)
        {
            bool success = _storeLogic.WriteInventory();

            if (success)
            {
                MessageBox.Show("Inventory saved successfully.");
            }
            else
            {
                MessageBox.Show("Inventory could not be saved.");
            }
        }

        /// <summary>
        /// Loads inventory from the text file.
        /// </summary>
        private void BtnLoadInventoryClickEH(object sender, EventArgs e)
        {
            _storeLogic.ReadInventory();
            _inventoryBindingSource.DataSource = _storeLogic.GetInventory();
            _inventoryBindingSource.ResetBindings(false);

            MessageBox.Show("Inventory loaded successfully.");
        }

        /// <summary>
        /// Removes the selected vehicle from the shopping cart.
        /// </summary>
        private void BtnRemoveFromCartClickEH(object sender, EventArgs e)
        {
            if (lstShoppingCart.SelectedItem is VehicleModel selectedVehicle)
            {
                _storeLogic.GetShoppingCart().Remove(selectedVehicle);
                _shoppingCartBindingSource.ResetBindings(false);
            }
        }

        /// <summary>
        /// Searches inventory by make, model, or year.
        /// </summary>
        private void BtnSearchClickEH(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _inventoryBindingSource.DataSource = _storeLogic.GetInventory();
                _inventoryBindingSource.ResetBindings(false);
                return;
            }

            var filteredInventory = _storeLogic.GetInventory()
                .Where(vehicle =>
                    vehicle.Make.ToLower().Contains(searchText) ||
                    vehicle.Model.ToLower().Contains(searchText) ||
                    vehicle.Year.ToString().Contains(searchText))
                .ToList();

            _inventoryBindingSource.DataSource = filteredInventory;
            _inventoryBindingSource.ResetBindings(false);
        }

        /// <summary>
        /// Sorts inventory by the selected sort option.
        /// </summary>
        private void BtnSortClickEH(object sender, EventArgs e)
        {
            string sortChoice = cmbSort.SelectedItem?.ToString() ?? "Make";

            var inventory = _storeLogic.GetInventory();

            switch (sortChoice)
            {
                case "Make":
                    inventory = inventory.OrderBy(vehicle => vehicle.Make).ToList();
                    break;

                case "Model":
                    inventory = inventory.OrderBy(vehicle => vehicle.Model).ToList();
                    break;

                case "Year":
                    inventory = inventory.OrderBy(vehicle => vehicle.Year).ToList();
                    break;

                case "Price":
                    inventory = inventory.OrderBy(vehicle => vehicle.Price).ToList();
                    break;
            }

            _inventoryBindingSource.DataSource = inventory;
            _inventoryBindingSource.ResetBindings(false);
        }
    }
}