using System.Windows.Forms;
using Test.FeatureClasses;
using Test.FeatureClasses.Feature3;//sadece static bir class bu şekilde eklenebilir.

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Feature1 - Primary Constructors

        private void linkLabelFeature1Old_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Feature1Old feature = new Feature1Old(1,2);
        }

        private void linkLabelFeature1New_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Feature1New feature = new Feature1New(1, 2);
            //Feature1New feature = new Feature1New();
        }

        #endregion

        #region Feature2 - Auto Property Initializer

        private void linkLabelFeature2Old_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Feature2Old feature = new Feature2Old(1, 2);
        }

        private void linkLabelFeature2New_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Feature2New feature = new Feature2New(1, 2);
        }

        #endregion

        #region Feature3 - Using Static

        private void linkLabelFeature3Old_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int value = Feature3.GetValue();
        }

        private void linkLabelFeature3New_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int value = GetValue();//using Test.FeatureClasses.Feature3; eklendiği için tip adı gerekmeksizin kullanılabilir.
        }

        #endregion

        #region Feature4 - Declaration Expressions

        private void linkLabelFeature4Old_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int value = new Feature4Old().GetValue("12");
        }

        private void linkLabelFeature4New_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int value = new Feature4New().GetValue("12");
        }

        #endregion

        #region Feature5 - Property Expressions

        private void linkLabelFeature5Old_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int value = new Feature5Old().Value;
        }

        private void linkLabelFeature5New_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int value = new Feature5New().Value;
        }

        #endregion

        #region Feature6 - Method Expressions

        private void linkLabelFeature6Old_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int value = new Feature6Old().GetValue();
        }

        private void linkLabelFeature6New_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int value = new Feature6New().GetValue();
        }

        #endregion

        #region Feature7 - Monadic Null Checking

        private void linkLabelFeature7Old_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int? value = new Feature7Old().GetValue();
        }

        private void linkLabelFeature7New_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int? value = new Feature7New().GetValue();
        }

        #endregion

        #region Feature8 - Exception Filters

        private void linkLabelFeature8Old_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string text = new Feature8Old().GetText();
        }

        private void linkLabelFeature8New_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string text = new Feature8New().GetText();
        }

        #endregion
    }
}
