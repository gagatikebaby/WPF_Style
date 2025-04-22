using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace uistyle.Page.DNA
{
    /// <summary>
    /// Interaction logic for DNAanimtion.xaml
    /// </summary>
    public partial class DNAanimtionPage 
    {
        private ParticleSystem ps;

        public DNAanimtionPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ps = new ParticleSystem(this.cvs_particleContainer);
            //注册帧动画
            CompositionTarget.Rendering += CompositionTarget_Rendering;
        }
        /// <summary>
        /// 帧渲染事件
        /// </summary>
        private void CompositionTarget_Rendering(object sender, EventArgs e)
        {
            ps.Update();
        }
    }
}

    

