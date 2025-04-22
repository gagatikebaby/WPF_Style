using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uistyle.Page;
using uistyle.Page.CubeWall3DPage;
using uistyle.Page.DNA;
using uistyle.Page.ParticleWave3D;
using Wpf.Ui.Controls;

namespace uistyle.ViewModel
{
    public partial class MainViewModel : ViewModel
    {

        [ObservableProperty]
        private ObservableCollection<object> _menuItems =
         [
            new NavigationViewItem("3D发光立方体",typeof(GlowingCube3DPage)),
            new NavigationViewItem("3D图像翻转",typeof(Flip3DPage)),
            new NavigationViewItem("3D发光墙",typeof(CubeWall3DPage)),
            new NavigationViewItem("3D发光墙",typeof(PartcleWare3DPage)),
            new NavigationViewItem("DNA螺旋粒子动画",typeof(DNAanimtionPage)),
         ];
    }
}
