using System;
using System.Collections.Generic;

namespace kitchorgapi.recipe
{
    public class Step
    {
        // Description: what to do
        // Time: How long does it take in minutes
    }

    public class StepList : List<Step>
    {
        // Time: sum of all steps
    }
}