﻿/*
 * BadRequestResultVariable.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.AspNetCore.Mvc;
using WFLite.Bases;
using WFLite.Interfaces;

namespace WFLite.AspNetCore.Variables
{
    public class BadRequestResultVariable : OutVariable<IActionResult>
    {
        public BadRequestResultVariable()
        {
        }

        public BadRequestResultVariable(IConverter<IActionResult> converter = null)
            : base(converter)
        {
        }

        protected override object getValue()
        {
            return new BadRequestResult();
        }
    }
}
