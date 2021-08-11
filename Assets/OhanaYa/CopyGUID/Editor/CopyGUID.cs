using UnityEditor;

namespace OhanaYa
{
    static class CopyGUID
    {
        const string MENU_ITEM_NAME = "Assets/Copy GUID";

        [MenuItem(MENU_ITEM_NAME, isValidateFunction: false)]
        static void Execute() => EditorGUIUtility.systemCopyBuffer = Selection.assetGUIDs[0];
        [MenuItem(MENU_ITEM_NAME, isValidateFunction: true)]
        static bool CanExecute() => Selection.assetGUIDs.Length > 0;
    }
}
