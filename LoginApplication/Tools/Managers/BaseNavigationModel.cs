using LoginApplication.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApplication.Tools.Managers
{
     internal class BaseNavigationModel: INavigationModel
    {
        private IContentOwner _contentOwner;
        private Dictionary<ViewType, INavigatable> _viewsDictionary;

        IContentOwner ContentOwner {
            get
            {
                return _contentOwner;
            }
            }
        Dictionary<ViewType, INavigatable> ViewsDictionary
        {
            get
            {
                return _viewsDictionary;
            }
        }
        internal BaseNavigationModel(IContentOwner contentOwner)
        {
            _contentOwner = contentOwner;
            _viewsDictionary = new Dictionary<ViewType, INavigatable>();
        }
        void InitializeView(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.SignIn:
                    _viewsDictionary.Add(viewType, new SignInUserControl());
                    break;
                case ViewType.SignUp:
                    _viewsDictionary.Add(viewType, new SignUpUserControl());
                    break;
                case ViewType.Main:
                    _viewsDictionary.Add(viewType, new SignInUserControl());
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

            public void Navigate(ViewType viewType)
        {
            if (!_viewsDictionary.ContainsKey(viewType))
            {
                InitializeView(viewType);
            }
            _contentOwner.ContentControl.Content = _viewsDictionary[viewType];
        }
        }
    }