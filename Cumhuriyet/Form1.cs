using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Xml.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeHollow.FeedReader;

namespace Cumhuriyet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void gundembutton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            get_gundem();
        }
        async void get_gundem()
        {
            string feedUrl = "https://www.cumhuriyet.com.tr/rss";

            var feed = await FeedReader.ReadAsync(feedUrl);
            var xDocument = XDocument.Parse(feed.OriginalDocument);
            var xNamespace = xDocument.Root.GetDefaultNamespace();
            int index = 0;
            foreach (var item in feed.Items)
            {
                var baseFeedItem = item.SpecificItem;
                string thumbnail = null;
                if (baseFeedItem.Element.Descendants().Any(x => x.Name.LocalName == xNamespace + "thumbnail"))
                {
                    thumbnail = baseFeedItem.Element.Descendants().First(x => x.Name.LocalName == xNamespace + "thumbnail").Attribute("url").Value;
                }
                index++;
                RSS_TekHaber rss = new RSS_TekHaber();
                rss.lbl_index.Text = index.ToString() + ".";
                rss.lbl_baslik.Text = ClearText(item.Title);
                rss.txt_aciklama.Text = ClearText(item.Description);
                rss.link_lbl_url.Text = item.Link;
                rss.lbl_Tarih.Text = item.PublishingDateString;
                rss.pic_gorsel.ImageLocation = thumbnail;
                rss.Margin = new Padding(0, -9, 0, 0);
                flowLayoutPanel1.Controls.Add(rss);
            }
        }
        async void get_kultur()
        {
            string feedUrl = "http://www.cumhuriyet.com.tr/rss/6.xml";

            var feed = await FeedReader.ReadAsync(feedUrl);
            var xDocument = XDocument.Parse(feed.OriginalDocument);
            var xNamespace = xDocument.Root.GetDefaultNamespace();
            int index = 0;
            foreach (var item in feed.Items)
            {
                var baseFeedItem = item.SpecificItem;
                string thumbnail = null;
                if (baseFeedItem.Element.Descendants().Any(x => x.Name.LocalName == xNamespace + "thumbnail"))
                {
                    thumbnail = baseFeedItem.Element.Descendants().First(x => x.Name.LocalName == xNamespace + "thumbnail").Attribute("url").Value;
                }
                index++;
                RSS_TekHaber rss = new RSS_TekHaber();
                rss.lbl_index.Text = index.ToString() + ".";
                rss.lbl_baslik.Text = ClearText(item.Title);
                rss.txt_aciklama.Text = ClearText(item.Description);
                rss.link_lbl_url.Text = item.Link;
                rss.lbl_Tarih.Text = item.PublishingDateString;
                rss.pic_gorsel.ImageLocation = thumbnail;
                rss.Margin = new Padding(0, -9, 0, 0);
                flowLayoutPanel1.Controls.Add(rss);
            }
        }
        async void get_cevre()
        {
            string feedUrl = "http://www.cumhuriyet.com.tr/rss/12.xml";

            var feed = await FeedReader.ReadAsync(feedUrl);
            var xDocument = XDocument.Parse(feed.OriginalDocument);
            var xNamespace = xDocument.Root.GetDefaultNamespace();
            int index = 0;
            foreach (var item in feed.Items)
            {
                var baseFeedItem = item.SpecificItem;
                string thumbnail = null;
                if (baseFeedItem.Element.Descendants().Any(x => x.Name.LocalName == xNamespace + "thumbnail"))
                {
                    thumbnail = baseFeedItem.Element.Descendants().First(x => x.Name.LocalName == xNamespace + "thumbnail").Attribute("url").Value;
                }
                index++;
                RSS_TekHaber rss = new RSS_TekHaber();
                rss.lbl_index.Text = index.ToString() + ".";
                rss.lbl_baslik.Text = ClearText(item.Title);
                rss.txt_aciklama.Text = ClearText(item.Description);
                rss.link_lbl_url.Text = item.Link;
                rss.lbl_Tarih.Text = item.PublishingDateString;
                rss.pic_gorsel.ImageLocation = thumbnail;
                rss.Margin = new Padding(0, -9, 0, 0);
                flowLayoutPanel1.Controls.Add(rss);
            }
        }
        async void get_magazin()
        {
            string feedUrl = "http://www.cumhuriyet.com.tr/rss/17.xml";

            var feed = await FeedReader.ReadAsync(feedUrl);
            var xDocument = XDocument.Parse(feed.OriginalDocument);
            var xNamespace = xDocument.Root.GetDefaultNamespace();
            int index = 0;
            foreach (var item in feed.Items)
            {
                var baseFeedItem = item.SpecificItem;
                string thumbnail = null;
                if (baseFeedItem.Element.Descendants().Any(x => x.Name.LocalName == xNamespace + "thumbnail"))
                {
                    thumbnail = baseFeedItem.Element.Descendants().First(x => x.Name.LocalName == xNamespace + "thumbnail").Attribute("url").Value;
                }
                index++;
                RSS_TekHaber rss = new RSS_TekHaber();
                rss.lbl_index.Text = index.ToString() + ".";
                rss.lbl_baslik.Text = ClearText(item.Title);
                rss.txt_aciklama.Text = ClearText(item.Description);
                rss.link_lbl_url.Text = item.Link;
                rss.lbl_Tarih.Text = item.PublishingDateString;
                rss.pic_gorsel.ImageLocation = thumbnail;
                rss.Margin = new Padding(0, -9, 0, 0);
                flowLayoutPanel1.Controls.Add(rss);
            }
        }
        async void get_yasam()
        {
            string feedUrl = "http://www.cumhuriyet.com.tr/rss/9.xml";

            var feed = await FeedReader.ReadAsync(feedUrl);
            var xDocument = XDocument.Parse(feed.OriginalDocument);
            var xNamespace = xDocument.Root.GetDefaultNamespace();
            int index = 0;
            foreach (var item in feed.Items)
            {
                var baseFeedItem = item.SpecificItem;
                string thumbnail = null;
                if (baseFeedItem.Element.Descendants().Any(x => x.Name.LocalName == xNamespace + "thumbnail"))
                {
                    thumbnail = baseFeedItem.Element.Descendants().First(x => x.Name.LocalName == xNamespace + "thumbnail").Attribute("url").Value;
                }
                index++;
                RSS_TekHaber rss = new RSS_TekHaber();
                rss.lbl_index.Text = index.ToString() + ".";
                rss.lbl_baslik.Text = ClearText(item.Title);
                rss.txt_aciklama.Text = ClearText(item.Description);
                rss.link_lbl_url.Text = item.Link;
                rss.lbl_Tarih.Text = item.PublishingDateString;
                rss.pic_gorsel.ImageLocation = thumbnail;
                rss.Margin = new Padding(0, -9, 0, 0);
                flowLayoutPanel1.Controls.Add(rss);
            }
        }
        async void get_saglik()
        {
            string feedUrl = "http://www.cumhuriyet.com.tr/rss/11.xml";

            var feed = await FeedReader.ReadAsync(feedUrl);
            var xDocument = XDocument.Parse(feed.OriginalDocument);
            var xNamespace = xDocument.Root.GetDefaultNamespace();
            int index = 0;
            foreach (var item in feed.Items)
            {
                var baseFeedItem = item.SpecificItem;
                string thumbnail = null;
                if (baseFeedItem.Element.Descendants().Any(x => x.Name.LocalName == xNamespace + "thumbnail"))
                {
                    thumbnail = baseFeedItem.Element.Descendants().First(x => x.Name.LocalName == xNamespace + "thumbnail").Attribute("url").Value;
                }
                index++;
                RSS_TekHaber rss = new RSS_TekHaber();
                rss.lbl_index.Text = index.ToString() + ".";
                rss.lbl_baslik.Text = ClearText(item.Title);
                rss.txt_aciklama.Text = ClearText(item.Description);
                rss.link_lbl_url.Text = item.Link;
                rss.lbl_Tarih.Text = item.PublishingDateString;
                rss.pic_gorsel.ImageLocation = thumbnail;
                rss.Margin = new Padding(0, -9, 0, 0);
                flowLayoutPanel1.Controls.Add(rss);
            }
        }
        async void get_bilim()
        {
            string feedUrl = "http://www.cumhuriyet.com.tr/rss/10.xml";

            var feed = await FeedReader.ReadAsync(feedUrl);
            var xDocument = XDocument.Parse(feed.OriginalDocument);
            var xNamespace = xDocument.Root.GetDefaultNamespace();
            int index = 0;
            foreach (var item in feed.Items)
            {
                var baseFeedItem = item.SpecificItem;
                string thumbnail = null;
                if (baseFeedItem.Element.Descendants().Any(x => x.Name.LocalName == xNamespace + "thumbnail"))
                {
                    thumbnail = baseFeedItem.Element.Descendants().First(x => x.Name.LocalName == xNamespace + "thumbnail").Attribute("url").Value;
                }
                index++;
                RSS_TekHaber rss = new RSS_TekHaber();
                rss.lbl_index.Text = index.ToString() + ".";
                rss.lbl_baslik.Text = ClearText(item.Title);
                rss.txt_aciklama.Text = ClearText(item.Description);
                rss.link_lbl_url.Text = item.Link;
                rss.lbl_Tarih.Text = item.PublishingDateString;
                rss.pic_gorsel.ImageLocation = thumbnail;
                rss.Margin = new Padding(0, -9, 0, 0);
                flowLayoutPanel1.Controls.Add(rss);
            }
        }
        string ClearText(string text)
        {
            try
            {
                return text.Replace("&#46;", "").Replace("<p>", "").Replace("</p>", "").Replace("<a>", "").Replace("</a>", "").Replace("&#8217;", "").Replace("[&#8230;]", "")
                     .Replace("<a rel=", "").Replace("nofollow", "").Replace("href=", "").Replace(">", "").Replace('"', ' ')
                     ;
            }
            catch (NullReferenceException ex)
            {
                return "Açıklama Bulunamadı";
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kultursanatbutton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            get_kultur();
        }

        private void cevrebutton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            get_cevre();
        }

        private void magazinbutton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            get_magazin();
        }

        private void yasambutton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            get_yasam();

        }

        private void saglikbutton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            get_saglik();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            get_bilim();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            get_gundem();
        }
    }
}
