using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Codemaker
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btngenerate_Click(object sender, EventArgs e)
        {
            string code = txtcode.Text;
            QRCoder.QRCodeGenerator qrgen = new QRCoder.QRCodeGenerator();
            QRCoder.QRCodeGenerator.QRCode qrcode = qrgen.CreateQrCode(code, QRCoder.QRCodeGenerator.ECCLevel.Q);

            System.Web.UI.WebControls.Image imgqrcode = new System.Web.UI.WebControls.Image();
            imgqrcode.Height = 150;
            imgqrcode.Width = 150;

            using (Bitmap bitmap = qrcode.GetGraphic(20))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] byteimage = ms.ToArray();
                    imgqrcode.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteimage);
                }
                Phqrcode.Controls.Add(imgqrcode);
            }
        }
    }
}