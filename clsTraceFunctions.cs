#define TRACE

using System.Collections.Generic;

namespace TAL.Web.Core
{
    /// <summary>
    /// The Trace functions class is designed to output the information contained within the webpage or dll where it is called to write information back to the
    /// trace portion of the web page.
    /// </summary>
    public class TraceFunctions
    {
        #region Class Declarations

        /// <summary>
        /// Make sure that we are using the current Http Context so that the information can be written to the page.
        /// </summary>
        System.Web.HttpContext traceContext = System.Web.HttpContext.Current;

        /// <summary>
        /// String list to be used for writing to update panels.
        /// </summary>
        System.String mstrMessages = "";

        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public TraceFunctions()
        {
        }

        #endregion

        #region subWriteMessage
        /// <summary>
        /// Subroutine that allows for writing trace information that contains only a message
        /// </summary>
        /// <param name="pstrMessage">The message to be displayed in the browser.</param>
        public void subWriteMessage(System.String pstrMessage)
        {
            traceContext.Trace.Write(pstrMessage);
        }

        /// <summary>
        /// Subroutine that allows for writing trace information that contains category and message
        /// </summary>
        /// <param name="pstrCategory">The Category to group the message content.</param>
        /// <param name="pstrMessage">The message to be displayed in the browser.</param>
        public void subWriteMessage(System.String pstrCategory, System.String pstrMessage)
        {
            traceContext.Trace.Write(pstrCategory, pstrMessage);
        }

        #endregion

        #region subWarnMessage
        /// <summary>
        /// Subroutine that allows for writing a warning to the trace information that contains a message
        /// </summary>
        /// <param name="pstrMessage">The message to be displayed in the browser.</param>
        public void subWarnMessage(System.String pstrMessage)
        {
            traceContext.Trace.Warn(pstrMessage);
        }

        /// <summary>
        /// Subroutine that allows for writing a warning to the trace information that contains a category and message
        /// </summary>
        /// <param name="pstrCategory">The category to group the message content.</param>
        /// <param name="pstrMessage">The message to be displayed in the browser.</param>
        public void subWarnMessage(System.String pstrCategory, System.String pstrMessage)
        {
            traceContext.Trace.Warn(pstrCategory, pstrMessage);
        }

        #endregion

        #region subWriteUpdatePanelMessage
        /// <summary>
        /// Function to write trace messages to a panel that is contained within an update panel.
        /// This is in place so that items can be traced within an update panel.
        /// </summary>
        /// <param name="ppnlMessage">The panel where the messages should appear.</param>
        /// <param name="pstrMessage">The message to display that contains the tracing information.</param>
        public void subWriteUpdatePanelMessage(ref System.Web.UI.WebControls.Panel ppnlMessage, System.String pstrMessage)
        {
            System.Web.UI.WebControls.Label lblMessageItem = new System.Web.UI.WebControls.Label();
            System.Web.UI.WebControls.Literal litLineBreak = new System.Web.UI.WebControls.Literal();
            litLineBreak.Text = @"<br />";
            pstrMessage = System.String.Format("{0}    {1}", pstrMessage, System.DateTime.Now.ToLongTimeString());

            if (ppnlMessage.Controls.Count > 0)
            {
                ppnlMessage.Visible = true;

                lblMessageItem.ID = System.String.Format("lblMessage{0}", ppnlMessage.Controls.Count);
                lblMessageItem.ForeColor = System.Drawing.Color.Red;
                lblMessageItem.Text = System.String.Format("{0}", pstrMessage);

                ppnlMessage.Controls.Add(lblMessageItem);
                ppnlMessage.Controls.Add(litLineBreak);

                mstrMessages = System.String.Format("{0}{1};", mstrMessages, pstrMessage);
                traceContext.Session["strTraceMessages"] = mstrMessages;
            }
            else
            {
                if (traceContext.Session["strTraceMessages"] == null)
                {
                    traceContext.Session.Add("strTraceMessages", mstrMessages);
                }
                else
                {
                    mstrMessages = traceContext.Session["strTraceMessages"].ToString();
                }

                mstrMessages = System.String.Format("{0}{1};", mstrMessages, pstrMessage);

                System.Collections.Generic.List<System.String> strListMessages = fncStringToList(mstrMessages);

                System.Web.UI.WebControls.Panel pnlPlaceholder = ppnlMessage;

                strListMessages.ForEach(h =>
                {
                    lblMessageItem = new System.Web.UI.WebControls.Label();
                    lblMessageItem.ID = System.String.Format("lblMessage{0}", pnlPlaceholder.Controls.Count);
                    lblMessageItem.ForeColor = System.Drawing.Color.Red;
                    lblMessageItem.Text = System.String.Format("{0}", h);
                    pnlPlaceholder.Controls.Add(lblMessageItem);
                    litLineBreak.ID = System.String.Format("litLineBreak{0}", pnlPlaceholder.Controls.Count);
                    pnlPlaceholder.Controls.Add(litLineBreak);
                });

                ppnlMessage = pnlPlaceholder;
                ppnlMessage.Visible = true;

                traceContext.Session["strTraceMessages"] = mstrMessages;
            }
        }

        #endregion

        #region fncStringToList
        /// <summary>
        /// Function to take the string items in the session and convert them to a list.
        /// </summary>
        /// <param name="pstrMessages"></param>
        /// <returns></returns>
        private List<System.String> fncStringToList(System.String pstrMessages)
        {
            System.Int32 intStringLength = pstrMessages.Length;
            System.Int32 intIndex = 0;
            System.Int32 intPrevIndex = 0;
            System.Collections.Generic.List<System.String> strlistMessages = new System.Collections.Generic.List<System.String>();

            while ((intIndex + 1) < intStringLength)
            {
                intPrevIndex = intIndex == 0 ? intIndex : (intIndex + 1);
                intIndex = pstrMessages.IndexOf(';', intPrevIndex);
                strlistMessages.Add(pstrMessages.Substring(intPrevIndex,(intIndex - (intPrevIndex))));
            }

            return strlistMessages;
        }

        #endregion
    }
}
