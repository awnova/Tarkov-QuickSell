# QuickSell

A mod for excape from tarkov that introduces more ways to sell your items quickly.

Two context menu options are added for items in the stash. They allow you to quick sell items to the flea or traders. When selling on the fleamarket items get listed for the average price shown on the add listing window. When selling items to traders the highest price offering is picked automatically. 

This mod is compatible with multiselect functionality of UIFixes if it is installed! Huge thanks to Tyfon for adding multiselect interop functionality into UIFixes.

If UIFixes is installed, QuickSell enables multiselect integration automatically by default. You can override this in `config.json` with `EnableUIFixesIntegration`.

Usage with UIFixes:
- Shift-click (or box-select) multiple stash items.
- Right-click one of the selected items and choose `QuickSell (Trader)` or `QuickSell (Flea)`, or use keybinds (`M`/`N`) while multiselect is active (hover is not required).
- A single confirmation dialog is shown with the total price, then sells/listings are executed sequentially.
