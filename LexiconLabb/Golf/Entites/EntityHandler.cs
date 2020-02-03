using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Golf.Entites
{
    public class EntityHandler
    {
        //Public Initialization
        public static List<string> AppFeatureAccess { get; set; }
        public static List<string> EntityFeatuers   { get; set; }

        // Private Initialization
        private enum AppEntities
        {
            Character,
            Item
        }
        private string _appFeatureRequest;
        private bool _defaultValuesSet;
        private int _runAppEntity;
        public EntityHandler()
        {
            if(AppFeatureAccess == null && EntityFeatuers == null)
            {
                EntityFeatuers = new List<string>();
                AppFeatureAccess = new List<string>();
            }
            if (_defaultValuesSet == false)
            {
                CreateEntityFeatureSignatures();
                SetDefaultValues();
            }
        }
        //Constructor Helper Methods
#region CMM
        private void CreateEntityFeatureSignatures()
        {
            foreach (var item in Enum.GetNames(typeof(AppEntities)))
                EntityFeatuers.Add(item);
        }
        private void SetDefaultValues()
        {
            _defaultValuesSet = true;
        }
#endregion
        //Class Methods
        public void LoadEntity(string appFeature)
        {
            if (appFeature == EntityFeatuers[0])
                _runAppEntity = (int)AppEntities.Character;
            //=================================\\
            else if (appFeature == EntityFeatuers[1])
                _runAppEntity = (int)AppEntities.Item;
            //=================================\\
            else
            {
                Debug.Print("||====================||" + Environment.NewLine
                            + "Error Code: unknown_app_feature" + Environment.NewLine
                            + $"appFeature: {appFeature}" + Environment.NewLine
                            + "Program location: EntityHandler.LoadEntity");
            }
            _appFeatureRequest = appFeature;
        }
        public void GetEntity()
        {

        }
    }
}