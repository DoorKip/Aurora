﻿using System.Windows.Controls;

namespace Aurora.Settings.Layers.Controls {

    public partial class Control_SolidFillLayer : UserControl {

        public Control_SolidFillLayer() {
            InitializeComponent();
        }

        public Control_SolidFillLayer(SolidFillLayerHandler context) {
            InitializeComponent();
            DataContext = context;
        }
    }
}
