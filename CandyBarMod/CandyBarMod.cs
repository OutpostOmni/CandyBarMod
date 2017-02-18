/**
 * This file is part of CandyBarMod, licensed under the MIT License (MIT).
 *
 * Copyright (c) 2017 Helion3 http://helion3.com/
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */
using OmniAPI;

// Create a new namespace unique to this mod.
// Note, it does not have to match the class name.
namespace CandyBarMod {
	// Create a new class which implements IMod. This will be
	// our primary class file, responsible for any initialization.
	public class CandyBarMod : Mod {
		// Execute some logic when the game scene has loaded
		public override void OnGameLoad(IGameManager gameManager) {
			// Register an item sprite from our asset bundle, so the game knows how to render it
			gameManager.GetItemManager().Register(this, CandyBarItem.ID, "assets/candy-bar.png");

			// Loop through all players
			foreach (IPlayer player in gameManager.GetPlayers()) {
				var playerInventory = player.GetInventory();

				// Ensure they don't have a candy bar already
				if (!playerInventory.Has(CandyBarItem.ID)) {
					// Give them a candy bar
					playerInventory.Add(new CandyBarItem());
				}
			}
		}
	}
}
