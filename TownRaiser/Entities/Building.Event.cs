using System;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Specialized;
using FlatRedBall.Audio;
using FlatRedBall.Screens;
using TownRaiser.Entities;
using TownRaiser.Screens;
namespace TownRaiser.Entities
{
	public partial class Building
	{
        void OnAfterBuildingDataSet (object sender, EventArgs e)
        {
            var animationName = BuildingData.Name;

            SpriteInstance.CurrentChainName = animationName;

            CurrentHealth = BuildingData.Health;
            //Setup the possible training units.
            foreach (var unit in BuildingData.TrainableUnits)
            {
                ButtonCountDisplays.Add(unit, 0);
            }

        }
		
	}
}
