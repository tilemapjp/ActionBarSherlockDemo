using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/actionbarsherlock",
						"com/actionbarsherlock/app",
						"com/actionbarsherlock/view",
						"com/actionbarsherlock/widget",
					},
					new Converter<string, Type>[]{
						lookup_com_actionbarsherlock_package,
						lookup_com_actionbarsherlock_app_package,
						lookup_com_actionbarsherlock_view_package,
						lookup_com_actionbarsherlock_widget_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_actionbarsherlock_mappings;
		static Type lookup_com_actionbarsherlock_package (string klass)
		{
			if (package_com_actionbarsherlock_mappings == null) {
				package_com_actionbarsherlock_mappings = new string[]{
					"com/actionbarsherlock/ActionBarSherlock:ActionBar_Sherlock.ActionBarSherlock",
				};
			}

			return Lookup (package_com_actionbarsherlock_mappings, klass);
		}

		static string[] package_com_actionbarsherlock_app_mappings;
		static Type lookup_com_actionbarsherlock_app_package (string klass)
		{
			if (package_com_actionbarsherlock_app_mappings == null) {
				package_com_actionbarsherlock_app_mappings = new string[]{
					"com/actionbarsherlock/app/ActionBar:ActionBar_Sherlock.App.ActionBar",
					"com/actionbarsherlock/app/ActionBar$LayoutParams:ActionBar_Sherlock.App.ActionBar/LayoutParams",
					"com/actionbarsherlock/app/ActionBar$Tab:ActionBar_Sherlock.App.ActionBar/Tab",
					"com/actionbarsherlock/app/SherlockActivity:ActionBar_Sherlock.App.SherlockActivity",
					"com/actionbarsherlock/app/SherlockDialogFragment:ActionBar_Sherlock.App.SherlockDialogFragment",
					"com/actionbarsherlock/app/SherlockExpandableListActivity:ActionBar_Sherlock.App.SherlockExpandableListActivity",
					"com/actionbarsherlock/app/SherlockFragment:ActionBar_Sherlock.App.SherlockFragment",
					"com/actionbarsherlock/app/SherlockFragmentActivity:ActionBar_Sherlock.App.SherlockFragmentActivity",
					"com/actionbarsherlock/app/SherlockListActivity:ActionBar_Sherlock.App.SherlockListActivity",
					"com/actionbarsherlock/app/SherlockListFragment:ActionBar_Sherlock.App.SherlockListFragment",
					"com/actionbarsherlock/app/SherlockPreferenceActivity:ActionBar_Sherlock.App.SherlockPreferenceActivity",
				};
			}

			return Lookup (package_com_actionbarsherlock_app_mappings, klass);
		}

		static string[] package_com_actionbarsherlock_view_mappings;
		static Type lookup_com_actionbarsherlock_view_package (string klass)
		{
			if (package_com_actionbarsherlock_view_mappings == null) {
				package_com_actionbarsherlock_view_mappings = new string[]{
					"com/actionbarsherlock/view/ActionMode:ActionBar_Sherlock.View.ActionMode",
					"com/actionbarsherlock/view/ActionProvider:ActionBar_Sherlock.View.ActionProvider",
					"com/actionbarsherlock/view/MenuInflater:ActionBar_Sherlock.View.MenuInflater",
					"com/actionbarsherlock/view/MenuInflater$InflatedOnMenuItemClickListener:ActionBar_Sherlock.View.MenuInflater/InflatedOnMenuItemClickListener",
					"com/actionbarsherlock/view/MenuInflater$MenuState:ActionBar_Sherlock.View.MenuInflater/MenuState",
					"com/actionbarsherlock/view/Window:ActionBar_Sherlock.View.Window",
				};
			}

			return Lookup (package_com_actionbarsherlock_view_mappings, klass);
		}

		static string[] package_com_actionbarsherlock_widget_mappings;
		static Type lookup_com_actionbarsherlock_widget_package (string klass)
		{
			if (package_com_actionbarsherlock_widget_mappings == null) {
				package_com_actionbarsherlock_widget_mappings = new string[]{
					"com/actionbarsherlock/widget/ShareActionProvider:ActionBar_Sherlock.Widget.ShareActionProvider",
					"com/actionbarsherlock/widget/ShareActionProvider$ShareAcitivityChooserModelPolicy:ActionBar_Sherlock.Widget.ShareActionProvider/ShareAcitivityChooserModelPolicy",
					"com/actionbarsherlock/widget/ShareActionProvider$ShareMenuItemOnMenuItemClickListener:ActionBar_Sherlock.Widget.ShareActionProvider/ShareMenuItemOnMenuItemClickListener",
				};
			}

			return Lookup (package_com_actionbarsherlock_widget_mappings, klass);
		}
	}
}
