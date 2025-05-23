﻿using System;
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
using System.Windows.Threading;

namespace uistyle.Page.ParticleWave3D
{
    /// <summary>
    /// Interaction logic for PartcleWare3DPage.xaml
    /// </summary>
    public partial class PartcleWare3DPage
    {
        private ParticleSystem _ps;
        private DispatcherTimer _frameTimer;
        public PartcleWare3DPage()
        {
            InitializeComponent();

            _frameTimer = new DispatcherTimer();
            _frameTimer.Tick += OnFrame;
            _frameTimer.Interval = TimeSpan.FromSeconds(1.0 / 60.0);
            _frameTimer.Start();

            _ps = new ParticleSystem(50, 50, Colors.White, 30);

            WorldModels.Children.Add(_ps.ParticleModel);

            _ps.SpawnParticle(30);

            Cursor = Cursors.None;
        }

        private void OnFrame(object sender, EventArgs e)
        {
            _ps.Update();
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            //避免页面关闭后资源占用
            _frameTimer.Stop();
            _frameTimer.Tick -= OnFrame;
            _frameTimer = null;
            _ps = null;
        }
    }
}

