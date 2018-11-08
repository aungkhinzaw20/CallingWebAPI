using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CallingWebAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static HttpClient client = new HttpClient();
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            client = new HttpClient();
            HttpResponseMessage response;
            client.BaseAddress = new Uri(txtURL.Text);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (rdoPost.Checked)
            {
                response = client.PostAsync(txtFunctionURL.Text, new StringContent(txtRequest.Text, Encoding.UTF8, "application/json")).Result;
            }
            else
                response = client.GetAsync(txtFunctionURL.Text).Result;


            if (response.IsSuccessStatusCode)
            {
                var _return = response.Content.ReadAsAsync<IEnumerable<object>>().Result;
                if (_return != null)
                    for (int i = 0; i < _return.ToList().Count; i++)
                    {
                        if (i == 0)
                            txtResponse.Text = _return.ToList()[i].ToString();
                        else
                            txtResponse.Text = txtResponse.Text + _return.ToList()[i].ToString();
                    }
                    
                else if (rdoPost.Checked)
                    txtResponse.Text = response.StatusCode.ToString();
            }
            else
            {
                txtResponse.Text = "Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase;
            }
            client.Dispose();
        }
    }
}
