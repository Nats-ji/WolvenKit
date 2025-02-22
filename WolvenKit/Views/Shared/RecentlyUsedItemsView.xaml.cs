// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RecentlyUsedFilesView.xaml.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.Shared
{
    public partial class RecentlyUsedItemsView
    {
        #region Constructors

        public RecentlyUsedItemsView()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("BackStage - Recently Used");
            }
        }

        #endregion Methods
    }
}
