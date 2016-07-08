# osu! Map Settings Customizer

For starters, none of this would have been remotely possible without https://osu.ppy.sh/u/Dubu.
His original VB.net version was the perfect scaffolding to build into this ~~monstrosity~~ masterpiece

That said, in order to add the features I wanted, I ended up rewriting almost all of the major moving parts.

I also just got done translating it into C# because A) it'll be easier to port, and B) why not.

I left the VB.net project in for now in case anyone wants to snoop, but I'll be scrapping it as soon as I get sick of trying to maintain both. (basically RIP ASAP)

Change log:

    Simplified GUI slightly and added visual theming

    Radically improved CLI (and hopefully improved performance)
      Can't see shit, captain: http://puu.sh/pT15x/71f18d2e36.png
        --> Sanity: http://puu.sh/pULm1/69030e7e4f.png
            This should hopefully enable people to use the CLI exclusively  

    Relative difficulty value changes
      Check 'Relative' and enter +/-x. Difficulty values will be incremented/decremented as expected.

To do:

    Finish implementing Update function (Soon™)
        Update existing [name] beatmaps to new settings (based on original settings, not current)
        Doesn't create new beatmaps.

    New Delete features
        Respect HP,CS,AR,OD selections
        Add Delete-All function if [name] is blank.
          (Idiot-proof, delete nothing if difficulty values are left at 0-10)

    Merge Create/Update/Delete and allow multiple modes simultaneously with intuitive logic.
        When combined:
          Create and update will perform their normal functions
          Delete will delete anything excluded from the difficulty value range

    Improve CLI output with colorized beatmap created/updated/deleted/skipped/error messages

Wishlist:

    Vertical/Horizontal flip (aka fake HR)
    BPM changing (aka fake DT/HT)
    Figure out how to make beatmap processing not take 5-6fuckingever on gigahuge collections
        Hopefully make it *almost* as fast as osu! collection updates (so like 4-5ever)
    Rewrite the whole fuckin thing (again) with .NET Core/Mono/whatever and make it multiplatform.
