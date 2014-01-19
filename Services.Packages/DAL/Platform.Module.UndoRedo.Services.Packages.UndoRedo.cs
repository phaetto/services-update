using System;
using System.Web;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

/*
 * High performance automated object model
 * Created by an automatic tool
 * Defines the internal templating controller that is resolving resources using REST architecture.
 * */

namespace Platform.Module.UndoRedo.Services.Packages
{
	[System.Runtime.InteropServices.ComVisible(false)]
    public static class Grouping
    {
		// Grouping is a single thread scope capability, so must be kept in memory before pushed in the data pool.
		// Single grouping is only possible, to group actions that result to multiple model actions

		internal static string activeName = null;
		static object synchronizationObject = new object();

		static public object SynchronizationObject
		{
            get
            {
                return synchronizationObject;
            }
		}

        public static void EnterUndoRedoGroup(string name)
        {
			if (!String.IsNullOrEmpty(activeName))
				throw new InvalidOperationException("The undo-redo is already to a group. You need to synchronize the operations using SynchronizationObject.");

			// Add group to activeNames collection
        }

        public static void ExitUndoRedoGroup(string name)
        {
			if (String.IsNullOrEmpty(activeName))
				throw new InvalidOperationException("The undo-redo is not in a group.");

			// Remove group from activeNames collection
        }

		internal static void GroupEntry(string type, long recordId)
		{
			if (String.IsNullOrEmpty(activeName))
				return; // Just return safely; we need no grouping
		}

		public static void UndoGroup(string name)
        {
			// Validate that all data are in position, and then undo
        }

		public static void RedoGroup(string name)
        {
			// Validate that all data are in position, and then redo
        }
    }
}