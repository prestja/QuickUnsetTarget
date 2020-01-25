using UnityEngine;
using KSP.UI.Screens;

namespace prestja {
	[KSPAddon(KSPAddon.Startup.Flight, false)]
	public class QuickUnset : MonoBehaviour {
		private ApplicationLauncherButton launcherButton;

		private void Start () {
			launcherButton = ApplicationLauncher.Instance.AddModApplication(
				() => { FlightGlobals.fetch.SetVesselTarget(null);},
				null, null, null, null, null, 
				ApplicationLauncher.AppScenes.FLIGHT, 
				GameDatabase.Instance.GetTexture("QuickUnsetTarget/icon", false));
		}

		private void OnDestroy() {
			ApplicationLauncher.Instance.RemoveModApplication(launcherButton);
		}
	}
}
