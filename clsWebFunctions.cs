
namespace TAL.Web.Core
{
    /// <summary>
    /// This assembly aids in web application development with the development of
    /// web ui, javascript, and other various functions and methods used
    /// by the web application development team.
    /// </summary>
    public class WebFunctions
    {

        #region Module Declarations

        /// <summary>
        /// A boolean used to determine whether the method name is shown
        /// if an error occurs.
        /// </summary>
        private System.Boolean mblnShowMethodName = true;

        /// <summary>
        /// A string value that will hold the prpstrLastErrDescription
        /// property value for any error.
        /// </summary>
        private System.String gstrLastErrDescription = "";

        #endregion

        #region Enumerations

        #region enmButtonType

        /// <summary>
        /// Enumerations for the various buttons available. These enumerations are used by
        /// the toolbar of all web based applications.
        /// </summary>
        public enum enmButtonType
        {
            /// <summary>
            /// Application level Add button
            /// </summary>
            enmAppAdd = 0,
            /// <summary>
            /// Application level Save button
            /// </summary>
            enmAppSave = 10,
            /// <summary>
            /// Application level Delete button
            /// </summary>
            enmAppDelete = 20,
            /// <summary>
            /// Application level Undo button
            /// </summary>
            enmAppUndo = 30,
            /// <summary>
            /// Application level Export button
            /// </summary>
            enmAppExport = 35,
            /// <summary>
            /// Application level Report Execute button
            /// </summary>
            enmRptExecute = 40,
            /// <summary>
            /// Application level Reset Report Filter button
            /// </summary>
            enmRptResetFilter = 50,
            /// <summary>
            /// Application level Execute Report Schema button
            /// </summary>
            enmRptExecuteSchema = 60,
            /// <summary>
            /// Application level Save Report Schema button
            /// </summary>
            enmRptSaveSchema = 70,
            /// <summary>
            /// Application level Delete Report Schema button
            /// </summary>
            enmRptDeleteSchema = 80,
            /// <summary>
            /// Application level Add Report Schema Schedule button
            /// </summary>
            enmRptAddSchemaSchedule = 82,
            /// <summary>
            /// Application level Delete Report Schema Schedule button
            /// </summary>
            enmRptDeleteSchemaSchedule = 84,
            /// <summary>
            /// Application level Report Schema Schedule button
            /// </summary>
            enmRptSchemaSchedule = 86,
            /// <summary>
            /// Custom button, pass in both button image file path and tooltip
            /// </summary>
            enmCustom = 90,
            /// <summary>
            /// Master Page level Add button
            /// </summary>
            enmMPAdd = 100,
            /// <summary>
            /// Master Page level Edit button
            /// </summary>
            enmMPEdit = 110,
            /// <summary>
            /// Master Page level Delete button
            /// </summary>
            enmMPDelete = 120,
            /// <summary>
            /// Master Page level Search button
            /// </summary>
            enmMPSearch = 130,
            /// <summary>
            /// Master Page level Reports button
            /// </summary>
            enmMPReports = 140,
            /// <summary>
            /// Master Page level Central Applications button
            /// </summary>
            enmMPCentralApplications = 150,
            /// <summary>
            /// Master Page level Central Reporting button
            /// </summary>
            enmMPCentralReporting = 160,
            /// <summary>
            /// Master Page level Help button
            /// </summary>
            enmMPHelp = 170,
            /// <summary>
            /// Master Page level Home button
            /// </summary>
            enmMPHome = 180,
            /// <summary>
            /// Master Page level Logoff button
            /// </summary>
            enmMPLogoff = 190,
            /// <summary>
            /// Master Page level Divider image
            /// </summary>
            enmMPDivider = 200,
            /// <summary>
            /// Application level Report Execute button
            /// </summary>
            enmFrmExecute = 210,
            /// <summary>
            /// Application level Reset Report Filter button
            /// </summary>
            enmFrmAdd = 220

        }

        #endregion

        #region enmOutputType
        /// <summary>
        /// Enumerations for the various report file types that will be available on the web.
        /// </summary>
        public enum enmOutputType
        {
            /// <summary>
            /// Generate a PDF File format.
            /// </summary>
            enmPDF = 10,
            /// <summary>
            /// Generate an XLS file format.
            /// </summary>
            enmXLS = 20,
            /// <summary>
            /// Generates a PDF File format.
            /// </summary>
            enmDefault = 30
        }

        #endregion

        #region enmDeliveryType
        /// <summary>
        /// Enumerations for the various report delivery types that will be available on the web.
        /// </summary>
        public enum enmDeliveryType
        {
            /// <summary>
            /// Generates the file inline.
            /// </summary>
            enmInline = 10,
            /// <summary>
            /// Generate the file as an attachment.
            /// </summary>
            enmAttachment = 20,
            /// <summary>
            /// Generates the file as an attachment.
            /// </summary>
            enmDefault = 30
        }

        #endregion

        #endregion

        #region Property Procedures

        /// <summary>
        /// This property returns/sets the description of the
        /// last error that occurred in the component 
        /// </summary>
        public System.String @prpstrLastErrDescription
        {
            get
            {
                return gstrLastErrDescription;
            }
            set
            {
                gstrLastErrDescription = value;
            }
        }
        /// <summary>
        /// This property determines whether or not the name of the 
        /// method/function is visible when the function fncReturnMethodName is called
        /// by an error trapping Catch
        /// </summary>
        public System.Boolean @prpblnShowMethodName
        {
            get
            {
                return mblnShowMethodName;
            }
            set
            {
                mblnShowMethodName = value;
            }
        }

        #endregion

        #region fncReturnMethodName

        /// <summary>
        /// This function determines whether or not the name of the 
        /// method/function is visible in error messages
        /// </summary>
        private System.String fncReturnMethodName(System.String pstrMethodName)
        {
            if (mblnShowMethodName)
            {
                return pstrMethodName + " ";
            }
            else
            {
                return "";
            }
        }

        #endregion

        #region Class Constructors

        /// <summary>
        /// Default Constructor for class
        /// </summary>
        public WebFunctions()
        {
        }

        /// <summary>
        /// Constructor for class that allows setting of the 
        /// 'Show Method Name' in error messages boolean
        /// </summary>
        /// <param name="pstrblnShowMethodName">Boolean used to set whether 
        /// method name is shown when error occurs.</param>
        public WebFunctions(System.Boolean pstrblnShowMethodName)
        {
            prpblnShowMethodName = pstrblnShowMethodName;
        }

        #endregion

        #region JavaScript Code

        #region fncJSHighLightText

        /// <summary>
        /// This script block MUST be registered in the page_load event of an ASP.NET
        /// web page.  This function highlights a web INPUT field. 
        /// <example>
        /// 	<para>First Register the JS code block:</para>
        /// 	<para>if (!ClientScript.IsClientScriptBlockRegistered("fncJSHighlightText"))</para>
        /// 	<para>{</para>
        /// 	<para>ClientScript.RegisterClientScriptBlock(this.GetType(), "fncJSHighlightText",
        ///     objCoreFncWeb15.fncJSHighlightText());</para>
        /// 	<para>}</para>
        /// 	<para> </para>
        /// 	<para>Second, call the following in your Page_Load event:</para>
        /// 	<para>txtTest.Attributes.Add("onclick", "fncJSHighlightText();");</para>
        /// 	<para> </para>
        /// </example>
        /// </summary>
        /// <returns>String with the valid JavaScript.</returns>
        public System.String fncJSHighlightText()
        {
            System.Text.StringBuilder sbScript = new System.Text.StringBuilder();
            sbScript.Append("<script type='text/javascript'>");
            sbScript.Append("function fncJSHighlightText()");
            sbScript.Append("{element=event.srcElement;");
            sbScript.Append("if (element.tagName=='INPUT')");
            sbScript.Append("{etype=element.type;");
            sbScript.Append("if (etype=='text')");
            sbScript.Append("{element.focus();");
            sbScript.Append("element.select();");
            sbScript.Append("}}}");
            sbScript.Append("</script>");
            return sbScript.ToString();
        }

        #endregion

        #region fncJSInitSign
        /// <summary>
        /// This script block MUST be registered in the page_load event of an ASP.NET
        /// web page.  This function reinitializes the signature block.
        /// <example>txtTest.Attributes.Add("", "fncJSInitSign();");</example> 
        /// </summary>
        /// <returns>String with the valid JavaScript.</returns>
        public System.String fncJSInitSign()
        {
            System.Text.StringBuilder sbScript = new System.Text.StringBuilder();
            sbScript.Append("<script language='javascript' type='text / javascript'>");
            sbScript.Append("function fncJSInitSign()");
            sbScript.Append("{ ");
            sbScript.Append("eval('obj' + '<%= ctlSignature.uID %>').Init();");
            sbScript.Append("ClearSignature('<%= ctlSignature.uID %>');");
            sbScript.Append("}");
            sbScript.Append("window.onbeforeunload;");
            sbScript.Append("function LoadSign(data) ");
            sbScript.Append("{ ");
            sbScript.Append("LoadSignature('<%= ctlSignature.uID %>', data, '1');");
            sbScript.Append("}");
            sbScript.Append("window.onbeforeunload;");
            sbScript.Append("</script>");
            return sbScript.ToString();

        }
        #endregion

        #region fncJSScreeningCalculationsKeyUp
        /// <summary>
        /// fncJSScreeningCalculationsKeyUp - returns keyup call
        /// </summary>
        /// <returns>JavaScript function</returns>
        public System.String fncJSScreeningCalculationsKeyUp()
        {
            return "fncJSScreeningCalculationsKeyUp(this,event);";
        }
        #endregion

        #region fncJSCreateDateMask
        /// <summary>
        /// This script block MUST be registered in the page_load event of an ASP.NET
        /// web page.  This function creates a Date Mask.
        /// <example>txtTest.Attributes.Add("onkeyup", "fncJSCreateDateMaskKeyUp();");</example> 
        /// </summary>
        /// <returns>String with the valid JavaScript.</returns>
        public System.String fncJSCreateDateMask()
        {
            System.Text.StringBuilder sbScript = new System.Text.StringBuilder();
            sbScript.Append("<script type='text/javascript'>");
            sbScript.Append("function fncJSCreateDateMask(ptxtTextBox,pEvent) ");
            sbScript.Append("{ ");
            sbScript.Append("var vstrValue = ptxtTextBox.value.replace('//','/');");
            sbScript.Append("ptxtTextBox.value = vstrValue.replace('//','/');");
            sbScript.Append("var vWhichCode = (window.Event) ? pEvent.which : pEvent.keyCode;");
            sbScript.Append("if (vWhichCode == 8) return false;");            
            sbScript.Append("if (vstrValue.length == 2) {");
            sbScript.Append("vstrValue = vstrValue + '/';");
            sbScript.Append("ptxtTextBox.value = vstrValue;");
            sbScript.Append("return false;}");
            sbScript.Append("if (vstrValue.length == 5) {");
            sbScript.Append("vstrValue = vstrValue + '/';");
            sbScript.Append("ptxtTextBox.value = vstrValue;");
            sbScript.Append("return false;}");
            sbScript.Append("}");
            sbScript.Append("</script>");
            return sbScript.ToString();
        }
        #endregion

        #region fncJSCreateDateMaskKeyUp
        /// <summary>
        /// fncJSCreateDateMaskKeyUp - returns keyup call
        /// </summary>
        /// <returns>JavaScript function</returns>
        public System.String fncJSCreateDateMaskKeyUp()
        {
            return "fncJSCreateDateMask(this,event);";
        }

        #endregion

        #region fncJSCreateDateTimeMask, fncJSCreateDateTimeMaskKeyUp

        /// <summary>
        /// This script block MUST be registered in the page_load event of an ASP.NET
        /// web page.  This function creates a DateTime Mask.
        /// <example>txtTest.Attributes.Add("onkeyup", "fncJSCreateDateTimeMaskKeyUp();");</example> 
        /// </summary>
        /// <returns>String with the valid JavaScript.</returns>
        public System.String fncJSCreateDateTimeMask()
        {
            System.Text.StringBuilder sbScript = new System.Text.StringBuilder();
            sbScript.Append("<script type='text/javascript'>");
            sbScript.Append("function fncJSCreateDateTimeMask(ptxtTextBox,pEvent) ");
            sbScript.Append("{ ");
            sbScript.Append("var vstrValue = ptxtTextBox.value;");
            sbScript.Append("var vWhichCode = (window.Event) ? pEvent.which : pEvent.keyCode;");
            sbScript.Append("if (vWhichCode == 8) return false;");
            sbScript.Append("if (vstrValue.length == 2) {");
            sbScript.Append("vstrValue = vstrValue + '/';");
            sbScript.Append("ptxtTextBox.value = vstrValue;");
            sbScript.Append("return false;}");
            sbScript.Append("if (vstrValue.length == 5) {");
            sbScript.Append("vstrValue = vstrValue + '/';");
            sbScript.Append("ptxtTextBox.value = vstrValue;");
            sbScript.Append("return false;}");
            sbScript.Append("if (vstrValue.length == 10) {");
            sbScript.Append("vstrValue = vstrValue + ' ';");
            sbScript.Append("ptxtTextBox.value = vstrValue;");
            sbScript.Append("return false;}");
            sbScript.Append("if (vstrValue.length == 13) {");
            sbScript.Append("vstrValue = vstrValue + ':';");
            sbScript.Append("ptxtTextBox.value = vstrValue;");
            sbScript.Append("return false;}");
            sbScript.Append("if (vstrValue.length == 16) {");
            sbScript.Append("vstrValue = vstrValue + ' AM';");
            sbScript.Append("ptxtTextBox.value = vstrValue;");
            sbScript.Append("return false;}");
            sbScript.Append("}");
            sbScript.Append("</script>");
            return sbScript.ToString();
        }

        /// <summary>
        /// fncJSCreateDateTimeMaskKeyUp - returns keyup call
        /// </summary>
        /// <returns>JavaScript function</returns>
        public System.String fncJSCreateDateTimeMaskKeyUp()
        {
            return "fncJSCreateDateTimeMask(this,event);";
        }

        #endregion

        #region fncJSCreateSSANMask, fncJSCreateSSANMaskKeyUp

        /// <summary>
        /// This script block MUST be registered in the page_load event of an ASP.NET
        /// web page.  This function creates a SSAN Mask.
        /// <example>txtTest.Attributes.Add("onkeyup", "fncJSCreateSSANMaskKeyUp();");</example>
        /// </summary>
        /// <returns>String with the valid JavaScript.</returns>
        public System.String fncJSCreateSSANMask()
        {
            System.Text.StringBuilder sbScript = new System.Text.StringBuilder();
            sbScript.Append("<script type='text/javascript'>");
            sbScript.Append("function fncJSCreateSSANMask(ptxtTextBox,pEvent) ");
            sbScript.Append("{ ");
            sbScript.Append("var vstrValue = ptxtTextBox.value;");
            sbScript.Append("var vWhichCode = (window.Event) ? pEvent.which : pEvent.keyCode;");
            sbScript.Append("if (vWhichCode == 8) return false;");
            sbScript.Append("if (vstrValue.length == 3) {");
            sbScript.Append("vstrValue = vstrValue + '-';");
            sbScript.Append("ptxtTextBox.value = vstrValue;");
            sbScript.Append("return false;}");
            sbScript.Append("if (vstrValue.length == 6) {");
            sbScript.Append("vstrValue = vstrValue + '-';");
            sbScript.Append("ptxtTextBox.value = vstrValue;");
            sbScript.Append("return false;}");
            sbScript.Append("}");
            sbScript.Append("</script>");
            return sbScript.ToString();
        }

        /// <summary>
        /// fncJSCreateSSANMaskKeyUp - returns keyup call
        /// </summary>
        /// <returns>JavaScript function</returns>
        public System.String fncJSCreateSSANMaskKeyUp()
        {
            return "fncJSCreateSSANMask(this,event);";
        }

        #endregion

        #region fncJSCreatePhoneMask, fncJSCreatePhoneMaskKeyUp

        /// <summary>
        /// This script block MUST be registered in the page_load event of an ASP.NET
        /// web page.  This function creates a Phone Mask.
        /// <example>txtTest.Attributes.Add("onkeyup", "fncJSCreatePhoneMaskKeyUp();");</example> 
        /// </summary>
        /// <returns>String with the valid JavaScript.</returns>
        public System.String fncJSCreatePhoneMask()
        {
            System.Text.StringBuilder sbScript = new System.Text.StringBuilder();
            sbScript.Append("<script type='text/javascript'>");
            sbScript.Append("function fncJSCreatePhoneMask(ptxtTextBox,pEvent) ");
            sbScript.Append("{ ");
            sbScript.Append("var vstrValue = ptxtTextBox.value;");
            sbScript.Append("var vWhichCode = (window.Event) ? pEvent.which : pEvent.keyCode;");
            sbScript.Append("if (vWhichCode == 8) return false;");
            sbScript.Append("if (vstrValue.length == 3) {");
            sbScript.Append("vstrValue = '(' + vstrValue + ') ';");
            sbScript.Append("ptxtTextBox.value = vstrValue;");
            sbScript.Append("return false;}");
            sbScript.Append("if (vstrValue.length == 9) {");
            sbScript.Append("vstrValue = vstrValue + '-';");
            sbScript.Append("ptxtTextBox.value = vstrValue;");
            sbScript.Append("return false;}");
            sbScript.Append("}");
            sbScript.Append("</script>");
            return sbScript.ToString();
        }

        /// <summary>
        /// fncJSCreatePhoneMaskKeyUp - returns keyup call
        /// </summary>
        /// <returns>JavaScript function</returns>
        public System.String fncJSCreatePhoneMaskKeyUp()
        {
            return "fncJSCreatePhoneMask(this,event);";
        }

        #endregion

        #region fncJSCreateTimeMask, fncJSCreateTimeMaskKeyUp
        /// <summary>
        /// This script block MUST be registered in the page_load event of an ASP.NET
        /// web page.  This function creates a Time Mask.
        /// <example>txtTest.Attributes.Add("onkeyup", "fncJSCreateTimeMaskKeyUp();");</example> 
        /// </summary>
        /// <returns>String with the valid JavaScript.</returns>
        public System.String fncJSCreateTimeMask()
        {
            System.Text.StringBuilder sbScript = new System.Text.StringBuilder();
            sbScript.Append("<script type='text/javascript'>");
            sbScript.Append("function fncJSCreateTimeMask(ptxtTextBox,pEvent) ");
            sbScript.Append("{ ");
            sbScript.Append("var vstrValue = ptxtTextBox.value;");
            sbScript.Append("var vWhichCode = (window.Event) ? pEvent.which : pEvent.keyCode;");
            sbScript.Append("if (vWhichCode == 8) return false;");
            sbScript.Append("if (vstrValue.length == 2) {");
            sbScript.Append("vstrValue = vstrValue + ':';");
            sbScript.Append("ptxtTextBox.value = vstrValue;");
            sbScript.Append("return false;}");
            sbScript.Append("if (vstrValue.length == 5) {");
            sbScript.Append("vstrValue = vstrValue + ' ';");
            sbScript.Append("ptxtTextBox.value = vstrValue;");
            sbScript.Append("return false;}");
            sbScript.Append("}");
            sbScript.Append("</script>");
            return sbScript.ToString();
        }

        /// <summary>
        /// fncJSCreateTimeMaskKeyUp - returns keyup call
        /// </summary>
        /// <returns>JavaScript function</returns>
        public System.String fncJSCreateTimeMaskKeyUp()
        {
            return "fncJSCreateTimeMask(this,event);";
        }

        #endregion

        #region fncJSTextBoxOnClick

        /// <summary>
        /// Used for simply selecting the text in a text box
        /// </summary>
        /// <returns>JavaScript function</returns>
        public System.String fncJSTextBoxOnClick()
        {
            return "this.select();";
        }

        #endregion

        #region fncJSAddListItem

        /// <summary>
        /// Adds items to a ListBox
        /// </summary>
        /// <returns>JavaScript function</returns>
        public System.String fncJSAddListItem()
        {
            System.Text.StringBuilder sbScript = new System.Text.StringBuilder();
            sbScript.Append("<script type='text/javascript'>");
            sbScript.Append("function fncJSAddListItem(pObjListBox,ptxtTextBox,ptxtTextBoxSave) ");
            sbScript.Append("{ ");
            sbScript.Append("var strValue = ptxtTextBox.value;");
            sbScript.Append("var strTrimmedValue = strValue.replace(/^\\s*|\\s*$/g,'');");
            sbScript.Append("if (strTrimmedValue != '')");
            sbScript.Append("{");
            sbScript.Append("var objNewListItem = new Option(ptxtTextBox.value,ptxtTextBox.value); ");
            sbScript.Append("var intNewIndex = pObjListBox.options.length; ");
            sbScript.Append("pObjListBox.options[intNewIndex] = objNewListItem; ");
            sbScript.Append("if (ptxtTextBoxSave.value != '')");
            sbScript.Append("{ ");
            sbScript.Append("ptxtTextBoxSave.value = ptxtTextBoxSave.value + '^' + ptxtTextBox.value ; ");
            sbScript.Append("}");
            sbScript.Append("else ");
            sbScript.Append("{ ");
            sbScript.Append("ptxtTextBoxSave.value = ptxtTextBox.value; ");
            sbScript.Append("}");
            sbScript.Append("ptxtTextBox.value = ''; ");
            sbScript.Append("}");
            sbScript.Append("ptxtTextBox.value=''");
            sbScript.Append("}");
            sbScript.Append("</script>");
            return sbScript.ToString();
        }

        #endregion

        #region subJSAddWaterMark

        /// <summary>
        /// Used to add watermark to any textbox field.
        /// </summary>
        /// <param name="textBox">System.Web.UI.WebControls.TextBox - The textbox you want to add
        /// the watermark to.</param>
        /// <param name="waterMarkText">System.String - The value of the watermark.</param>
        public void subJSAddWaterMark(ref System.Web.UI.WebControls.TextBox textBox, string waterMarkText)
        {
            textBox.Attributes.Add("OnFocus", "javascript:JSWaterMarkFocus(this, '" + waterMarkText.Replace("'", "\\'") + "')");
            textBox.Attributes.Add("OnBlur", "javascript:JSWaterMarkBlur(this, '" + waterMarkText.Replace("'", "\\'") + "')");
            textBox.Text = waterMarkText;
            textBox.CssClass = "WaterMarkedTextBox";
            if (!(textBox.Page.ClientScript.IsClientScriptBlockRegistered("WaterMarkScript")))
            {
                System.Text.StringBuilder sbScript = new System.Text.StringBuilder();
                sbScript.Append("<script type='text/javascript'>" + System.Environment.NewLine);
                sbScript.Append("function JSWaterMarkFocus(txtElem, strWatermark) " + System.Environment.NewLine);
                sbScript.Append("{ " + System.Environment.NewLine);
                sbScript.Append("if (txtElem.value == strWatermark) " + System.Environment.NewLine);
                sbScript.Append("{ " + System.Environment.NewLine);
                sbScript.Append("txtElem.value = '';" + System.Environment.NewLine);
                sbScript.Append("txtElem.className='NormalTextBox'; " + System.Environment.NewLine);
                sbScript.Append("}" + System.Environment.NewLine);
                sbScript.Append("}" + System.Environment.NewLine);
                sbScript.Append("function JSWaterMarkBlur(txtElem, strWatermark) " + System.Environment.NewLine);
                sbScript.Append("{ " + System.Environment.NewLine);
                sbScript.Append("if (txtElem.value == '') " + System.Environment.NewLine);
                sbScript.Append("{ " + System.Environment.NewLine);
                sbScript.Append("txtElem.value = strWatermark; " + System.Environment.NewLine);
                sbScript.Append("txtElem.className='WaterMarkedTextBox'; " + System.Environment.NewLine);
                sbScript.Append("}" + System.Environment.NewLine);
                sbScript.Append("}" + System.Environment.NewLine);
                sbScript.Append("</script>" + System.Environment.NewLine);
                textBox.Page.ClientScript.RegisterClientScriptBlock(textBox.Page.GetType(), "WaterMarkScript", sbScript.ToString(), false);
            }
        }

        #endregion

        #endregion

        #region Web UI Functions

        #region fncCreateButtons Public/Overloads

        /// <summary>
        /// fncCreateButtons - Function returns the ImageButton for the MasterPages
        /// </summary>
        /// <param name="ppnlPanel">System.Web.UI.WebControls.Panel - Name of Panel where button will be added</param>
        /// <param name="penmButtons">enmButtons- Enum name of button</param> 
        /// <returns>System.Web.UI.WebControls.ImageButton - An image button</returns>
        public System.Web.UI.WebControls.ImageButton fncCreateButtons(System.Web.UI.WebControls.Panel ppnlPanel, enmButtonType penmButtons)
        {
            return fncCreateButtonsPrivate(ppnlPanel, penmButtons, "", "", "");
        }

        /// <summary>
        /// fncCreateButtons - Function returns the ImageButton for the MasterPages
        /// </summary>
        /// <param name="ppnlPanel">System.Web.UI.WebControls.Panel - Name of Panel where button will be added</param>
        /// <param name="penmButtons">enmButtons- Enum name of button</param>
        /// <param name="pstrIncrement">System.String - Name of suffix/increment (Overoad - if more than 1 button with same name exists)</param>
        /// <returns>System.Web.UI.WebControls.ImageButton - An image button</returns>
        public System.Web.UI.WebControls.ImageButton fncCreateButtons(System.Web.UI.WebControls.Panel ppnlPanel, enmButtonType penmButtons, System.String pstrIncrement)
        {
            return fncCreateButtonsPrivate(ppnlPanel, penmButtons, pstrIncrement, "", "");
        }

        /// <summary>
        /// fncCreateCustomButtons - Function returns the ImageButton for the MasterPages
        /// </summary>
        /// <param name="ppnlPanel">System.Web.UI.WebControls.Panel - Name of Panel where button will be added</param>
        /// <param name="pstrName">System.String- Name of custom button</param>
        /// <param name="pstrIncrement">System.String - Name of suffix/increment (Overoad - if more than 1 button with same name exists)</param>
        /// <param name="pstrToolTip">System.String - The tooltip that will be displayed</param>
        /// <param name="pstrImagePath">System.String - The image path for the imagebutton that will be displayed</param>
        /// <returns>System.Web.UI.WebControls.ImageButton - An image button</returns>
        public System.Web.UI.WebControls.ImageButton fncCreateCustomButtons(System.Web.UI.WebControls.Panel ppnlPanel, System.String pstrName, System.String pstrIncrement, System.String pstrToolTip, System.String pstrImagePath)
        {
            return fncCreateCustomButtonsPrivate(ppnlPanel, pstrName, pstrIncrement, pstrToolTip, pstrImagePath);
        }

        #endregion

        #region fncCreateButtonsPrivate

        /// <summary>
        /// fncCreateButtonsPrivate - Function returns ImageButtons to populate parameters
        /// </summary>
        /// <param name="pPanel">System.Web.UI.WebControls.Panel - Name of Panel where button will be added</param>
        /// <param name="penmButtons">enmButtons- Enum name of button</param>
        /// <param name="pIncrement">System.String - Name of increment (Overoad - if more than 1 button with same name exists)</param>
        /// <param name="pToolTip">System.String - The tooltip that will be displayed</param>
        /// <param name="pImagePath">System.String - The image path for the imagebutton that will be displayed</param>
        /// <returns>System.Web.UI.WebControls.ImageButton - A pre-built image button</returns>
        private System.Web.UI.WebControls.ImageButton fncCreateButtonsPrivate(System.Web.UI.WebControls.Panel pPanel, enmButtonType penmButtons, System.String pIncrement, System.String pToolTip, System.String pImagePath)
        {
            System.Web.UI.WebControls.ImageButton imgButton = new System.Web.UI.WebControls.ImageButton();
            System.String strTip = "";

            switch (penmButtons)
            {
                case enmButtonType.enmMPAdd:
                    strTip = "Add Record";
                    imgButton.ImageUrl = "/SiteImages/toolbar/MP/FolderAdd_Plain.png";
                    break;
                case enmButtonType.enmMPEdit:
                    strTip = "Edit Record";
                    imgButton.ImageUrl = "/SiteImages/toolbar/MP/FolderEdit_Plain.png";
                    break;
                case enmButtonType.enmMPDelete:
                    strTip = "Delete Record";
                    imgButton.ImageUrl = "/SiteImages/toolbar/MP/FolderDelete_Plain.png";
                    imgButton.Attributes.Add("onclick", "javascript:return confirm('Are you sure you want to delete the current record?')");
                    break;
                case enmButtonType.enmMPSearch:
                    strTip = "Search Records";
                    imgButton.ImageUrl = "/SiteImages/toolbar/MP/FolderSearch_Plain.png";
                    break;
                case enmButtonType.enmMPReports:
                    strTip = "Reports";
                    imgButton.ImageUrl = "/SiteImages/toolbar/MP/FolderBook_Plain.png";
                    break;
                case enmButtonType.enmMPCentralApplications:
                    strTip = "Back to Central Applications";
                    imgButton.ImageUrl = "/SiteImages/toolbar/MP/BackCentralApp_Plain.png";
                    break;
                case enmButtonType.enmMPCentralReporting:
                    strTip = "Back to Central Reporting";
                    imgButton.ImageUrl = "/SiteImages/toolbar/MP/BackCentralRep_Plain.png";
                    break;
                case enmButtonType.enmMPHelp:
                    strTip = "Help";
                    imgButton.ImageUrl = "/SiteImages/toolbar/MP/Help_Plain.png";
                    break;
                case enmButtonType.enmMPHome:
                    strTip = "Home";
                    imgButton.ImageUrl = "/SiteImages/toolbar/MP/Home_Plain.png";
                    break;
                case enmButtonType.enmMPLogoff:
                    strTip = "Logoff";
                    imgButton.ImageUrl = "/SiteImages/toolbar/MP/Logoff_Plain.png";
                    break;
                case enmButtonType.enmMPDivider:
                    strTip = "";
                    imgButton.ImageUrl = "/SiteImages/toolbar/divider.png";
                    break;
                case enmButtonType.enmAppAdd:
                    strTip = "Add Record";
                    imgButton.ImageUrl = "/SiteImages/toolbar/DataEntry/Add_Plain.png";
                    break;
                case enmButtonType.enmAppSave:
                    strTip = "Save Record";
                    imgButton.ImageUrl = "/SiteImages/toolbar/DataEntry/Save_Plain.png";
                    break;
                case enmButtonType.enmAppDelete:
                    strTip = "Delete Record";
                    imgButton.ImageUrl = "/SiteImages/toolbar/DataEntry/Delete_Plain.png";
                    imgButton.Attributes.Add("onclick", "javascript:return confirm('Are you sure you want to delete the current record?')");
                    break;
                case enmButtonType.enmAppUndo:
                    strTip = "Reset Record";
                    imgButton.ImageUrl = "/SiteImages/toolbar/DataEntry/Reset_Plain.png";
                    break;
                case enmButtonType.enmAppExport:
                    strTip = "Export Record Set";
                    imgButton.ImageUrl = "/SiteImages/toolbar/DataEntry/Export_Plain.png";
                    break;
                case enmButtonType.enmRptExecute:
                    strTip = "Execute Selected Report";
                    imgButton.ImageUrl = "/SiteImages/Toolbar/Reports/rptExecute_Plain.png";
                    imgButton.Attributes.Add("onclick", "javascript:window.status='Executing Selected Report... Please Wait...'");
                    break;
                case enmButtonType.enmRptResetFilter:
                    strTip = "Reset Filters";
                    imgButton.ImageUrl = "/SiteImages/Toolbar/reports/Reset_Plain.png";
                    break;
                case enmButtonType.enmRptExecuteSchema:
                    strTip = "Execute Report Selected In 'My Reports'";
                    imgButton.ImageUrl = "/SiteImages/Toolbar/reports/rptExecuteSchema_Plain.png";
                    imgButton.Attributes.Add("onclick", "javascript:window.status='Executing Selected My Report... Please Wait...'");
                    break;
                case enmButtonType.enmRptSaveSchema:
                    strTip = "Save Report Report To 'My Reports'";
                    imgButton.ImageUrl = "/SiteImages/Toolbar/reports/rptSaveSchema_Plain.png";
                    break;
                case enmButtonType.enmRptDeleteSchema:
                    strTip = "Delete Selected Report From 'My Reports'";
                    imgButton.ImageUrl = "/SiteImages/Toolbar/reports/rptDeleteSchema_Plain.png";
                    imgButton.Attributes.Add("onclick", "javascript:return confirm('Are you sure you want to delete the selected report from My Reports?')");
                    break;
                case enmButtonType.enmRptAddSchemaSchedule:
                    strTip = "Save Report Schedule To 'My Reports'";
                    imgButton.ImageUrl = "/SiteImages/Toolbar/reports/rptAddSchemaSchedule_Plain.png";
                    break;
                case enmButtonType.enmRptDeleteSchemaSchedule:
                    strTip = "Delete Report Schedule From 'My Reports'";
                    imgButton.ImageUrl = "/SiteImages/Toolbar/reports/rptDeleteSchemaSchedule_Plain.png";
                    imgButton.Attributes.Add("onclick", "javascript:return confirm('Are you sure you want to delete the selected schedule from My Reports?')");
                    break;
                case enmButtonType.enmRptSchemaSchedule:
                    strTip = "'My Reports' Schedule";
                    imgButton.ImageUrl = "/SiteImages/toolbar/reports/rptSchemaSchedule_Plain.png";
                    break;
                case enmButtonType.enmFrmAdd:
                    strTip = "Add New Record";
                    imgButton.ImageUrl = "/SiteImages/toolbar/FilterResults/FolderAdd_Plain.png";
                    break;
                case enmButtonType.enmFrmExecute:
                    strTip = "Retrieve Selected Records";
                    imgButton.ImageUrl = "/SiteImages/toolbar/FilterResults/Retrieve_Plain.png";
                    imgButton.Attributes.Add("onclick", "javascript:window.status='Generating Filters... Please Wait...'");
                    break;
                default:
                    strTip = pToolTip;
                    imgButton.ImageUrl = pImagePath;
                    break;
            }

            imgButton.AlternateText = strTip;
            imgButton.ToolTip = strTip;
            imgButton.CssClass = "imgPad";
            imgButton.ID = penmButtons + pIncrement;
            imgButton.ImageAlign = System.Web.UI.WebControls.ImageAlign.AbsMiddle;
            imgButton.Attributes.Add("onmouseout", "this.src='" + imgButton.ImageUrl + "';");
            imgButton.Attributes.Add("onmouseover", "this.src='" + imgButton.ImageUrl.Replace("Plain", "Shadow") + "';");
            pPanel.Controls.Add(imgButton);
            return imgButton;
        }

        #endregion

        #region fncCreateCustomButtonsPrivate

        /// <summary>
        /// fncCreateCustomButtonsPrivate - Function returns ImageButtons to populate parameters
        /// </summary>
        /// <param name="pPanel">System.Web.UI.WebControls.Panel - Name of Panel where button will be added</param>
        /// <param name="pstrName">System.String - Name of custom button</param>
        /// <param name="pIncrement">System.String - Name of increment (Overoad - if more than 1 button with same name exists)</param>
        /// <param name="pToolTip">System.String - The tooltip that will be displayed</param>
        /// <param name="pImagePath">System.String - The image path for the imagebutton that will be displayed</param>
        /// <returns>System.Web.UI.WebControls.ImageButton - An image button built based on parameters.</returns>
        private System.Web.UI.WebControls.ImageButton fncCreateCustomButtonsPrivate(System.Web.UI.WebControls.Panel pPanel, System.String pstrName, System.String pIncrement, System.String pToolTip, System.String pImagePath)
        {
            System.Web.UI.WebControls.ImageButton imgButton = new System.Web.UI.WebControls.ImageButton();
            System.String strTip = "";

            strTip = pToolTip;
            imgButton.ImageUrl = pImagePath;
            imgButton.AlternateText = strTip;
            imgButton.ToolTip = strTip;
            imgButton.ID = pstrName + pIncrement;
            imgButton.ImageAlign = System.Web.UI.WebControls.ImageAlign.AbsMiddle;
            imgButton.Attributes.Add("onmouseout", "this.src='" + imgButton.ImageUrl + "';");
            imgButton.Attributes.Add("onmouseover", "this.src='" + imgButton.ImageUrl.Replace("Plain", "Shadow") + "';");
            pPanel.Controls.Add(imgButton);
            return imgButton;

        }

        #endregion

        #region fncCreateToolbarDropdownList

        /// <summary>
        /// fncCreateToolbarDropdownList - Function returns a dropdown list for the master toolbar.
        /// </summary>
        /// <param name="pPanel">Name of the Panel where the dropdown list will be added.</param>
        /// <param name="pCombobox">Name of the combo box passed in.</param>
        /// <param name="pstrName">The name of the control.</param>
        /// <returns></returns>
        public void fncCreateToolbarDropdownList(System.Web.UI.WebControls.Panel pPanel, ref System.Web.UI.WebControls.DropDownList pCombobox, System.String pstrName)
        {
            pCombobox.ID = pstrName;
            pCombobox.AutoPostBack = true;
            pPanel.Controls.Add(pCombobox);
        }

        #endregion

        #region fncHoverImageButton

        /// <summary>
        /// fncHoverImageButton - adds the Image to hover status.
        /// </summary>
        /// <param name="pImageButton">System.Web.UI.WebControls.ImageButton - Pass the image you want to add hover attributes to</param>
        /// <returns>System.Boolean - Returns true if successful</returns>
        public System.Boolean fncHoverImageButton(System.Web.UI.WebControls.ImageButton pImageButton)
        {
            try
            {
                System.Web.UI.WebControls.ImageButton imgButton = pImageButton;
                imgButton.Attributes.Add("onmouseout", "this.src='" + imgButton.ImageUrl + "';");
                imgButton.Attributes.Add("onmouseover", "this.src='" + imgButton.ImageUrl.Replace("Plain", "Shadow") + "';");
                System.String strName = imgButton.ImageUrl.ToString();
                strName = strName.ToLower();
                return true;
            }
            catch (System.Exception ex)
            {
                prpstrLastErrDescription = fncReturnMethodName(System.Reflection.MethodBase.GetCurrentMethod().Name) + ex.Message.ToString();
                return false;
            }
        }

        #endregion

        #region fncBindControl

        /// <summary>
        /// This function will build a dataset and populate(Combo / ListBox) objects on a data entry form. 
        /// The control will hold a copy of the dataset created by this function.
        /// </summary>
        /// <param name="pstrSQL">SQL Statement for the data adapter</param>
        /// <param name="pintValueMember">Index for primary key location within the dataset.
        /// This value will be used to bind the dataset to the combo or listbox.</param>
        /// <param name="pintDisplayMember">Indicates which dataset field to display to user.</param>
        /// <param name="pobjFormControl">Pointer to the DropDownList control that will be populated.</param>
        /// <param name="pCN">Pointer to the ADO connection object.</param>
        /// <returns>Boolean of True if successful, False otherwise</returns>
        public System.Boolean fncBindControl(System.String pstrSQL, System.Int32 pintValueMember, System.Int32 pintDisplayMember, ref System.Web.UI.WebControls.DropDownList pobjFormControl, ref System.Data.SqlClient.SqlConnection pCN)
        {

            System.Data.DataSet DS = new System.Data.DataSet();
            System.Data.SqlClient.SqlDataAdapter DA = new System.Data.SqlClient.SqlDataAdapter();
            try
            {
                DA.SelectCommand = new System.Data.SqlClient.SqlCommand();
                DA.SelectCommand.Connection = pCN;
                DA.SelectCommand.CommandText = pstrSQL;
                DA.SelectCommand.CommandType = System.Data.CommandType.Text;
                DA.SelectCommand.CommandTimeout = 20;
                DA.SelectCommand.UpdatedRowSource = System.Data.UpdateRowSource.None;
                DA.Fill(DS);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    pobjFormControl.DataSource = DS.Tables[0];
                    pobjFormControl.DataMember = DS.Tables[0].TableName;
                    pobjFormControl.DataTextField = DS.Tables[0].Columns[pintDisplayMember].ColumnName;
                    pobjFormControl.DataValueField = DS.Tables[0].Columns[pintValueMember].ColumnName;
                    pobjFormControl.DataBind();
                }
                return true;
            }
            catch (System.Exception ex)
            {
                prpstrLastErrDescription = fncReturnMethodName(System.Reflection.MethodBase.GetCurrentMethod().Name) + ex.Message.ToString();
                return false;
            }
            finally
            {
                DA.Dispose();
                DS.Dispose();
            }
        }

        /// <summary>
        /// This function will build a dataset and populate(Combo / ListBox) objects on a data entry form. 
        /// The control will hold a copy of the dataset created by this function.
        /// </summary>
        /// <param name="pstrSQL">SQL Statement for the data adapter</param>
        /// <param name="pintValueMember">Index for primary key location within the dataset.
        /// This value will be used to bind the dataset to the combo or listbox.</param>
        /// <param name="pintDisplayMember">Indicates which dataset field to display to user.</param>
        /// <param name="pobjFormControl">Pointer to the ListBox control that will be populated.</param>
        /// <param name="pCN">Pointer to the ADO connection object.</param>
        /// <returns>Boolean of True if successful, False otherwise</returns>
        public System.Boolean fncBindControl(System.String pstrSQL, System.Int32 pintValueMember, System.Int32 pintDisplayMember, ref System.Web.UI.WebControls.ListBox pobjFormControl, ref System.Data.SqlClient.SqlConnection pCN)
        {

            System.Data.DataSet DS = new System.Data.DataSet();
            System.Data.SqlClient.SqlDataAdapter DA = new System.Data.SqlClient.SqlDataAdapter();
            try
            {
                DA.SelectCommand = new System.Data.SqlClient.SqlCommand();
                DA.SelectCommand.Connection = pCN;
                DA.SelectCommand.CommandText = pstrSQL;
                DA.SelectCommand.CommandType = System.Data.CommandType.Text;
                DA.SelectCommand.CommandTimeout = 20;
                DA.SelectCommand.UpdatedRowSource = System.Data.UpdateRowSource.None;
                DA.Fill(DS);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    pobjFormControl.DataSource = DS.Tables[0];
                    pobjFormControl.DataMember = DS.Tables[0].TableName;
                    pobjFormControl.DataTextField = DS.Tables[0].Columns[pintDisplayMember].ColumnName;
                    pobjFormControl.DataValueField = DS.Tables[0].Columns[pintValueMember].ColumnName;
                    pobjFormControl.DataBind();
                }
                return true;
            }
            catch (System.Exception ex)
            {
                prpstrLastErrDescription = fncReturnMethodName(System.Reflection.MethodBase.GetCurrentMethod().Name) + ex.Message.ToString();
                return false;
            }
            finally
            {
                DA.Dispose();
                DS.Dispose();
            }
        }

        /// <summary>
        /// This function will build a dataset and populate(Combo / ListBox) objects on a data entry form. 
        /// The control will hold a copy of the dataset created by this function.
        /// </summary>
        /// <param name="pDS">Dataset used to populate control.</param>
        /// <param name="pintValueMember">Index for primary key location within the dataset.
        /// This value will be used to bind the dataset to the combo or listbox.</param>
        /// <param name="pintDisplayMember">Indicates which dataset field to display to user.</param>
        /// <param name="pobjFormControl">Pointer to the ListBox control that will be populated.</param>
        /// <returns>Boolean of True if successful, False otherwise</returns>
        public System.Boolean fncBindControl(System.Data.DataSet pDS, System.Int32 pintValueMember, System.Int32 pintDisplayMember, ref System.Web.UI.WebControls.ListBox pobjFormControl)
        {
            try
            {

                if (pDS.Tables[0].Rows.Count > 0)
                {
                    pobjFormControl.DataSource = pDS.Tables[0];
                    pobjFormControl.DataMember = pDS.Tables[0].TableName;
                    pobjFormControl.DataTextField = pDS.Tables[0].Columns[pintDisplayMember].ColumnName;
                    pobjFormControl.DataValueField = pDS.Tables[0].Columns[pintValueMember].ColumnName;
                    pobjFormControl.DataBind();
                }
                return true;
            }
            catch (System.Exception ex)
            {
                prpstrLastErrDescription = fncReturnMethodName(System.Reflection.MethodBase.GetCurrentMethod().Name) + ex.Message.ToString();
                return false;
            }
            finally
            {
                pDS.Dispose();
            }
        }

        /// <summary>
        /// This function will build a dataset and populate(Combo / ListBox) objects on a data entry form. 
        /// The control will hold a copy of the dataset created by this function.
        /// </summary>
        /// <param name="pDS">Dataset used to populate control.</param>
        /// <param name="pintValueMember">Index for primary key location within the dataset.
        /// This value will be used to bind the dataset to the combo or listbox.</param>
        /// <param name="pintDisplayMember">Indicates which dataset field to display to user.</param>
        /// <param name="pobjFormControl">Pointer to the DropDownList control that will be populated.</param>
        /// <returns>Boolean of True if successful, False otherwise</returns>
        public System.Boolean fncBindControl(System.Data.DataSet pDS, System.Int32 pintValueMember, System.Int32 pintDisplayMember, ref System.Web.UI.WebControls.DropDownList pobjFormControl)
        {
            try
            {

                if (pDS.Tables[0].Rows.Count > 0)
                {
                    pobjFormControl.DataSource = pDS.Tables[0];
                    pobjFormControl.DataMember = pDS.Tables[0].TableName;
                    pobjFormControl.DataTextField = pDS.Tables[0].Columns[pintDisplayMember].ColumnName;
                    pobjFormControl.DataValueField = pDS.Tables[0].Columns[pintValueMember].ColumnName;
                    pobjFormControl.DataBind();
                }
                return true;
            }
            catch (System.Exception ex)
            {
                prpstrLastErrDescription = fncReturnMethodName(System.Reflection.MethodBase.GetCurrentMethod().Name) + ex.Message.ToString();
                return false;
            }
            finally
            {
                pDS.Dispose();
            }
        }

        #endregion

        #region fncPopulateMonthsControl

        /// <summary>
        /// Populates a DropDownList with number of months.
        /// </summary>
        /// <param name="pobjFormControl">Pass the DropDownList by Ref.</param>
        /// <returns>Returns true if successful.</returns>
        public System.Boolean fncPopulateMonthsControl(ref System.Web.UI.WebControls.DropDownList pobjFormControl)
        {
            try
            {
                //Populate the credit card expiration month drop down 
                for (int i = 1; i <= 12; i++)
                {
                    System.DateTime month = new System.DateTime(2000, i, 1);
                    System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(month.ToString("MMM (M)"), month.Month.ToString());
                    pobjFormControl.Items.Add(li);
                }
                pobjFormControl.Items.FindByValue(System.DateTime.Now.Month.ToString()).Selected = true;
                return true;
            }
            catch (System.Exception ex)
            {
                prpstrLastErrDescription = fncReturnMethodName(System.Reflection.MethodBase.GetCurrentMethod().Name) + ex.Message.ToString();
                return false;
            }
        }

        #endregion

        #region fncPopulateYearsControl

        /// <summary>
        /// Populates a DropDownList with number of years based on forward and back years.
        /// </summary>
        /// <param name="pobjFormControl">Pass the DropDownList by Ref.</param>
        /// <param name="pintYearsBack">Go back this number of years.</param>
        /// <param name="pintYearsForward">Go forward this number of years.</param>
        /// <returns>Returns true if successful.</returns>
        public System.Boolean fncPopulateYearsControl(ref System.Web.UI.WebControls.DropDownList pobjFormControl, System.Int32 pintYearsBack, System.Int32 pintYearsForward)
        {
            try
            {
                System.String year = "";
                // Handle the years backward.
                for (int i = 1; i <= pintYearsBack; i++)
                {
                    year = System.DateTime.Now.AddYears(-i).Year.ToString();
                    pobjFormControl.Items.Add(year);
                }
                // Add the current year.
                pobjFormControl.Items.Add(System.DateTime.Now.Year.ToString());

                // Add the years forward to the list.
                for (int i = 1; i <= pintYearsForward; i++)
                {
                    year = System.DateTime.Now.AddYears(i).Year.ToString();
                    pobjFormControl.Items.Add(year);
                }

                //Set the selected value to the current year
                pobjFormControl.Items.FindByValue(System.DateTime.Now.Year.ToString()).Selected = true;

                return true;
            }
            catch (System.Exception ex)
            {
                prpstrLastErrDescription = fncReturnMethodName(System.Reflection.MethodBase.GetCurrentMethod().Name) + ex.Message.ToString();
                return false;
            }
        }

        #endregion

        #endregion

        #region Web Reporting Functions

        //#region fncRunReport Public/Overloads

        ///// <summary>
        ///// Helper function to place a report into the response stream.
        ///// </summary>
        ///// <param name="pCurrentResponse">The current response object.</param>
        ///// <param name="pRPT">The report to be written.</param>
        ///// <param name="penmOutputType">The report output type.</param>
        ///// <returns>Returns true if successful.</returns>
        //public System.Boolean fncRunReport( System.Web.UI.Page pCurrentResponse, GrapeCity.ActiveReports.SectionReport pRPT, enmOutputType penmOutputType )
        //{
        //    return fncRunReportPrivate(pCurrentResponse, pRPT, penmOutputType, enmDeliveryType.enmDefault, "");
        //}

        ///// <summary>
        ///// Helper function to place a report into the response stream.
        ///// </summary>
        ///// <param name="pCurrentResponse">The current response object.</param>
        ///// <param name="pRPT">The report to be written.</param>
        ///// <param name="penmOutputType">The report output type.</param>
        ///// <param name="penmDeliveryType">The report delivery type:  Attachment (Default) or Inline.</param>
        ///// <returns></returns>
        //public System.Boolean fncRunReport( System.Web.UI.Page pCurrentResponse, GrapeCity.ActiveReports.SectionReport pRPT, enmOutputType penmOutputType, enmDeliveryType penmDeliveryType )
        //{
        //    return fncRunReportPrivate(pCurrentResponse, pRPT, penmOutputType, penmDeliveryType, "");
        //}

        ///// <summary>
        ///// Helper function to place a report into the response stream.
        ///// </summary>
        ///// <param name="pCurrentResponse">The current response object.</param>
        ///// <param name="pRPT">The report to be written.</param>
        ///// <param name="penmOutputType">The report output type.</param>
        ///// <param name="penmDeliveryType">The report delivery type:  Attachment (Default) or Inline.</param>
        ///// <param name="pstrReportName">The optional report name.</param>
        ///// <returns></returns>
        //public System.Boolean fncRunReport( System.Web.UI.Page pCurrentResponse, GrapeCity.ActiveReports.SectionReport pRPT, enmOutputType penmOutputType, enmDeliveryType penmDeliveryType, System.String pstrReportName )
        //{
        //    return fncRunReportPrivate(pCurrentResponse, pRPT, penmOutputType, penmDeliveryType, pstrReportName);
        //}

        //#endregion

        //#region fncRunReportPrivate

        ///// <summary>
        ///// Helper function to place a report into the response stream.
        ///// </summary>
        ///// <param name="pCurrentResponse">The current response object.</param>
        ///// <param name="pRPT">The report to be written.</param>
        ///// <param name="penmOutputType">Report output type:  PDF (Default), Excel.</param>
        ///// <param name="penmDeliveryType">Report deliver type: attachment (Default) or inline.</param>
        ///// <param name="pstrFileName">Optional file name of the report to be generated.</param>
        //private System.Boolean fncRunReportPrivate(System.Web.UI.Page pCurrentResponse, GrapeCity.ActiveReports.SectionReport pRPT, enmOutputType penmOutputType, enmDeliveryType penmDeliveryType, System.String pstrFileName)
        //{
        //    try
        //    {
        //        pCurrentResponse.Response.Clear();
        //        pCurrentResponse.Response.ClearContent();
        //        pCurrentResponse.Response.ClearHeaders();

        //        // Create a new memory stream that will hold the export output
        //        System.IO.MemoryStream memStream = new System.IO.MemoryStream();
        //        System.String strFileExtension = "";
        //        System.String strFileName = "";
        //        System.String strDeliveryType = "";
        //        switch (penmDeliveryType)
        //        {
        //            case enmDeliveryType.enmAttachment:
        //            case enmDeliveryType.enmDefault:
        //                strDeliveryType = "attachment";
        //                break;
        //            case enmDeliveryType.enmInline:
        //                strDeliveryType = "inline";
        //                break;
        //        }

        //        switch (penmOutputType)
        //        {
        //            case enmOutputType.enmPDF:
        //            case enmOutputType.enmDefault:
        //                pCurrentResponse.Response.ContentType = "application/pdf";
        //                strFileExtension = ".pdf";
        //                strFileName = (pstrFileName == "") ? "MyPDF" : pstrFileName;
        //                break;

        //            case enmOutputType.enmXLS:
        //                pCurrentResponse.Response.ContentType = "application/vnd.ms-excel";
        //                strFileExtension = ".xls";
        //                strFileName = (pstrFileName == "") ? "MyExcel" : pstrFileName;
        //                break;
        //        }

        //        // IE & Acrobat seem to require "content-disposition" header being in the response.
        //        // If you don't add it, the doc still works most of the time, but not always.
        //        // this makes a new window appear: Response.AddHeader("content-disposition","attachment; filename=MyPDF.PDF");
        //        pCurrentResponse.Response.AddHeader("content-disposition", strDeliveryType + "; filename=" + strFileName + strFileExtension);

        //        switch (penmOutputType)
        //        {
        //            case enmOutputType.enmPDF:
        //            case enmOutputType.enmDefault:
        //                // Create the PDF export object
        //                GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport pdf = new GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport();
        //                //GrapeCity.ActiveReports.Export.Pdf.PdfExport pdf = new GrapeCity.ActiveReports.Export.Pdf.PdfExport();
        //                // Export the report to PDF:
        //                pdf.Export(pRPT.Document, memStream);
        //                break;
                        
        //            case enmOutputType.enmXLS:
        //                // Create the Excel export object
        //                GrapeCity.ActiveReports.Export.Excel.Section.XlsExport xls = new GrapeCity.ActiveReports.Export.Excel.Section.XlsExport();
        //                xls.FileFormat = GrapeCity.ActiveReports.Export.Excel.Section.FileFormat.Xls97Plus;
        //                //xls.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape;
        //                //xls.UseCellMerging = true;
        //                //GrapeCity.ActiveReports.Export.Xls.XlsExport xls = new GrapeCity.ActiveReports.Export.Xls.XlsExport(); 
        //                // Export the report to Excel:
        //                xls.Export( pRPT.Document, memStream );
        //                break;
        //        }

        //        // Write the PDF stream out
        //        memStream.Position = 0;
        //        pCurrentResponse.Response.AddHeader("content-length", memStream.Length.ToString());
        //        pCurrentResponse.Response.BinaryWrite(memStream.ToArray());
        //        // Send all buffered content to the client
        //        pCurrentResponse.Response.End();
        //        return true;
        //    }
        //    catch (System.Exception ex)
        //    {
        //        prpstrLastErrDescription = ex.Message;
        //        return false;
        //    }
        //}

        //#endregion

        #endregion

        #region String Functions

        #region fncCreateCssLink

        /// <summary>
        /// Returns code with a resolved path for adding CSS links to an ASP.NET page.
        /// </summary>
        /// <param name="cssFilePath">The relative path to the CSS file (~/Styles/file.css)</param>
        /// <param name="media">Media attribute</param>
        /// <returns>The HTML text for adding CSS links to a page.</returns>
        /// <example>Page.Header.Controls.Add(Helper.CreateCssLink("~/Styles/styles.css", "screen"));</example>
        public static System.Web.UI.HtmlControls.HtmlLink fncCreateCssLink(string cssFilePath, string media)
        {
            var link = new System.Web.UI.HtmlControls.HtmlLink();
            link.Attributes.Add("type", "text/css");
            link.Attributes.Add("rel", "stylesheet");
            link.Href = link.ResolveUrl(cssFilePath);
            if (string.IsNullOrEmpty(media))
            {
                media = "all";
            }

            link.Attributes.Add("media", media);
            return link;
        }

        #endregion

        #region fncCreateJavaScriptLink

        /// <summary>
        /// Returns code with a resolve path for adding JavaScript references to an ASP.NET page.
        /// </summary>
        /// <param name="scriptFilePath">The relative path to the JavaScript file (~/Scripts/file.js)</param>
        /// <returns>The HTML text for adding JavaScript links to a page</returns>
        /// <example>Page.Header.Controls.Add(Helper.CreateJavaScriptLink("~/Scripts/swfobject.js"));</example>
        public static System.Web.UI.HtmlControls.HtmlGenericControl fncCreateJavaScriptLink(string scriptFilePath)
        {
            var script = new System.Web.UI.HtmlControls.HtmlGenericControl();
            script.TagName = "script";
            script.Attributes.Add("type", "text/javascript");
            script.Attributes.Add("src", script.ResolveUrl(scriptFilePath));

            return script;
        }

        #endregion

        #endregion

    }
}


