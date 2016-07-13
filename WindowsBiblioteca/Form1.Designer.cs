namespace WindowsBiblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblFNacimiento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cboNacionalidad = new System.Windows.Forms.ComboBox();
            this.dtpFNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblEdad = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnLista = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(111, -1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(210, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ingrese datos del autor";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblNacionalidad, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCodigo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFNacimiento, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblApellido, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCodigo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNombre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtApellido, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAgregar, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCerrar, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cboNacionalidad, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpFNacimiento, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(411, 274);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(3, 196);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(199, 13);
            this.lblNacionalidad.TabIndex = 4;
            this.lblNacionalidad.Text = "Nacionalidad";
            this.lblNacionalidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(3, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(199, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Codigo";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFNacimiento
            // 
            this.lblFNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFNacimiento.AutoSize = true;
            this.lblFNacimiento.Location = new System.Drawing.Point(3, 151);
            this.lblFNacimiento.Name = "lblFNacimiento";
            this.lblFNacimiento.Size = new System.Drawing.Size(199, 13);
            this.lblFNacimiento.TabIndex = 2;
            this.lblFNacimiento.Text = "Fecha de nacimiento";
            this.lblFNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(3, 106);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(199, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido del autor";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(3, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(199, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del autor";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigo.Location = new System.Drawing.Point(208, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(38, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(208, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido.Location = new System.Drawing.Point(208, 102);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(3, 238);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(199, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(208, 238);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(200, 23);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cboNacionalidad
            // 
            this.cboNacionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNacionalidad.FormattingEnabled = true;
            this.cboNacionalidad.Items.AddRange(new object[] {
            "Afganistan",
            "Africa del Sur",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Antigua y Barbuda",
            "Antillas Holandesas",
            "Arabia Saudita",
            "Argelia",
            "Argentina",
            "Armenia",
            "Aruba",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarusia",
            "Belgica",
            "Belice",
            "Benin",
            "Bermudas",
            "Bolivia",
            "Bosnia",
            "Botswana",
            "Brasil",
            "Brunei Darussulam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Butan",
            "Camboya",
            "Camerun",
            "Canada",
            "Cape Verde",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "Colombia",
            "Comoros",
            "Congo",
            "Corea del Norte",
            "Corea del Sur",
            "Costa de Marfíl",
            "Costa Rica",
            "Croasia",
            "Cuba",
            "Dinamarca",
            "Djibouti",
            "Dominica",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "Emiratos Arabes Unidos",
            "Eritrea",
            "Eslovenia",
            "España",
            "Estados Unidos",
            "Estonia",
            "Etiopia",
            "Fiji",
            "Filipinas",
            "Finlandia",
            "Francia",
            "Gabon",
            "Gambia",
            "Georgia",
            "Ghana",
            "Granada",
            "Grecia",
            "Groenlandia",
            "Guadalupe",
            "Guam",
            "Guatemala",
            "Guayana Francesa",
            "Guerney",
            "Guinea",
            "Guinea-Bissau",
            "Guinea Equatorial",
            "Guyana",
            "Haiti",
            "Holanda",
            "Honduras",
            "Hong Kong",
            "Hungria",
            "India",
            "Indonesia",
            "Irak",
            "Iran",
            "Irlanda",
            "Islandia",
            "Islas Caiman",
            "Islas Faroe",
            "Islas Malvinas",
            "Islas Marshall",
            "Islas Solomon",
            "Islas Virgenes Britanicas",
            "Islas Virgenes (U.S.)",
            "Israel",
            "Italia",
            "Jamaica",
            "Japon",
            "Jersey",
            "Jordania",
            "Kazakhstan",
            "Kenia",
            "Kiribati",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lesotho",
            "Libano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Macao",
            "Macedonia",
            "Madagascar",
            "Malasia",
            "Malawi",
            "Maldivas",
            "Mali",
            "Malta",
            "Marruecos",
            "Martinica",
            "Mauricio",
            "Mauritania",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Mozambique",
            "Myanmar (Burma)",
            "Namibia",
            "Nepal",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Noruega",
            "Nueva Caledonia",
            "Nueva Zealandia",
            "Oman",
            "Pakistan",
            "Palestina",
            "Panama",
            "Papua Nueva Guinea",
            "Paraguay",
            "Peru",
            "Polinesia Francesa",
            "Polonia",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Reino Unido",
            "Republica Centroafricana",
            "Republica Checa",
            "Republica Democratica del Congo",
            "Republica Dominicana",
            "Republica Eslovaca",
            "Reunion",
            "Ruanda",
            "Rumania",
            "Rusia",
            "Sahara",
            "Samoa",
            "San Cristobal-Nevis (St. Kitts)",
            "San Marino",
            "San Vincente y las Granadinas",
            "Santa Helena",
            "Santa Lucia",
            "Santa Sede (Vaticano)",
            "Sao Tome & Principe",
            "Senegal",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Siria",
            "Somalia",
            "Sri Lanka (Ceilan)",
            "Sudan",
            "Sudan del Sur",
            "Suecia",
            "Suiza",
            "Sur Africa",
            "Surinam",
            "Swaziland",
            "Tailandia",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Timor Oriental",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trinidad & Tobago",
            "Tunisia",
            "Turkmenistan",
            "Turquia",
            "Ucrania",
            "Uganda",
            "Union Europea",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe "});
            this.cboNacionalidad.Location = new System.Drawing.Point(208, 192);
            this.cboNacionalidad.Name = "cboNacionalidad";
            this.cboNacionalidad.Size = new System.Drawing.Size(200, 21);
            this.cboNacionalidad.TabIndex = 12;
            // 
            // dtpFNacimiento
            // 
            this.dtpFNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFNacimiento.Location = new System.Drawing.Point(208, 147);
            this.dtpFNacimiento.Name = "dtpFNacimiento";
            this.dtpFNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFNacimiento.TabIndex = 8;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(15, 318);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(0, 13);
            this.lblEdad.TabIndex = 2;
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(12, 340);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(408, 150);
            this.dgvLista.TabIndex = 4;
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(183, 313);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(75, 23);
            this.btnLista.TabIndex = 5;
            this.btnLista.Text = "Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(435, 491);
            this.ControlBox = false;
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblFNacimiento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.DateTimePicker dtpFNacimiento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cboNacionalidad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnLista;
    }
}

