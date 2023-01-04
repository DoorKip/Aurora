﻿using System.Collections.Generic;
using SBAuroraReactive;

namespace Aurora.Devices.Creative;

static class SoundBlasterMappings
{
    internal static KeyValuePair<Keyboard_LEDIndex, DeviceKeys>[] KeyboardMapping_All = {
            new(Keyboard_LEDIndex.Esc, DeviceKeys.ESC),
            new(Keyboard_LEDIndex.F1, DeviceKeys.F1),
            new(Keyboard_LEDIndex.F2, DeviceKeys.F2),
            new(Keyboard_LEDIndex.F3, DeviceKeys.F3),
            new(Keyboard_LEDIndex.F4, DeviceKeys.F4),
            new(Keyboard_LEDIndex.F5, DeviceKeys.F5),
            new(Keyboard_LEDIndex.F6, DeviceKeys.F6),
            new(Keyboard_LEDIndex.F7, DeviceKeys.F7),
            new(Keyboard_LEDIndex.F8, DeviceKeys.F8),
            new(Keyboard_LEDIndex.F9, DeviceKeys.F9),
            new(Keyboard_LEDIndex.F10, DeviceKeys.F10),
            new(Keyboard_LEDIndex.F11, DeviceKeys.F11),
            new(Keyboard_LEDIndex.F12, DeviceKeys.F12),
            new(Keyboard_LEDIndex.M1, DeviceKeys.G1),
            new(Keyboard_LEDIndex.BackQuote, DeviceKeys.TILDE),
            new(Keyboard_LEDIndex.Digit1, DeviceKeys.ONE),
            new(Keyboard_LEDIndex.Digit2, DeviceKeys.TWO),
            new(Keyboard_LEDIndex.Digit3, DeviceKeys.THREE),
            new(Keyboard_LEDIndex.Digit4, DeviceKeys.FOUR),
            new(Keyboard_LEDIndex.Digit5, DeviceKeys.FIVE),
            new(Keyboard_LEDIndex.Digit6, DeviceKeys.SIX),
            new(Keyboard_LEDIndex.Digit7, DeviceKeys.SEVEN),
            new(Keyboard_LEDIndex.Digit8, DeviceKeys.EIGHT),
            new(Keyboard_LEDIndex.Digit9, DeviceKeys.NINE),
            new(Keyboard_LEDIndex.Digit0, DeviceKeys.ZERO),
            new(Keyboard_LEDIndex.Minus, DeviceKeys.MINUS),
            new(Keyboard_LEDIndex.Equal, DeviceKeys.EQUALS),
            new(Keyboard_LEDIndex.Backspace, DeviceKeys.BACKSPACE),
            new(Keyboard_LEDIndex.M2, DeviceKeys.G2),
            new(Keyboard_LEDIndex.Tab, DeviceKeys.TAB),
            new(Keyboard_LEDIndex.Q, DeviceKeys.Q),
            new(Keyboard_LEDIndex.W, DeviceKeys.W),
            new(Keyboard_LEDIndex.E, DeviceKeys.E),
            new(Keyboard_LEDIndex.R, DeviceKeys.R),
            new(Keyboard_LEDIndex.T, DeviceKeys.T),
            new(Keyboard_LEDIndex.Y, DeviceKeys.Y),
            new(Keyboard_LEDIndex.U, DeviceKeys.U),
            new(Keyboard_LEDIndex.I, DeviceKeys.I),
            new(Keyboard_LEDIndex.O, DeviceKeys.O),
            new(Keyboard_LEDIndex.P, DeviceKeys.P),
            new(Keyboard_LEDIndex.OpenBracket, DeviceKeys.OPEN_BRACKET),
            new(Keyboard_LEDIndex.ClosedBracket, DeviceKeys.CLOSE_BRACKET),
            new(Keyboard_LEDIndex.BackSlash, DeviceKeys.BACKSLASH),         //Only on US
            new(Keyboard_LEDIndex.M3, DeviceKeys.G3),
            new(Keyboard_LEDIndex.CapsLock, DeviceKeys.CAPS_LOCK),
            new(Keyboard_LEDIndex.A, DeviceKeys.A),
            new(Keyboard_LEDIndex.S, DeviceKeys.S),
            new(Keyboard_LEDIndex.D, DeviceKeys.D),
            new(Keyboard_LEDIndex.F, DeviceKeys.F),
            new(Keyboard_LEDIndex.G, DeviceKeys.G),
            new(Keyboard_LEDIndex.H, DeviceKeys.H),
            new(Keyboard_LEDIndex.J, DeviceKeys.J),
            new(Keyboard_LEDIndex.K, DeviceKeys.K),
            new(Keyboard_LEDIndex.L, DeviceKeys.L),
            new(Keyboard_LEDIndex.Semicolon, DeviceKeys.SEMICOLON),
            new(Keyboard_LEDIndex.Apostrophe, DeviceKeys.APOSTROPHE),
            new(Keyboard_LEDIndex.NonUS57, DeviceKeys.HASHTAG),             //Only on European
            new(Keyboard_LEDIndex.Enter, DeviceKeys.ENTER),
            new(Keyboard_LEDIndex.M4, DeviceKeys.G4),
            new(Keyboard_LEDIndex.LeftShift, DeviceKeys.LEFT_SHIFT),
            new(Keyboard_LEDIndex.NonUS61, DeviceKeys.BACKSLASH_UK),        //Only on European
            new(Keyboard_LEDIndex.Z, DeviceKeys.Z),
            new(Keyboard_LEDIndex.X, DeviceKeys.X),
            new(Keyboard_LEDIndex.C, DeviceKeys.C),
            new(Keyboard_LEDIndex.V, DeviceKeys.V),
            new(Keyboard_LEDIndex.B, DeviceKeys.B),
            new(Keyboard_LEDIndex.N, DeviceKeys.N),
            new(Keyboard_LEDIndex.M, DeviceKeys.M),
            new(Keyboard_LEDIndex.Comma, DeviceKeys.COMMA),
            new(Keyboard_LEDIndex.Fullstop, DeviceKeys.PERIOD),
            new(Keyboard_LEDIndex.ForwardSlash, DeviceKeys.FORWARD_SLASH),
            new(Keyboard_LEDIndex.RightShift, DeviceKeys.RIGHT_SHIFT),
            new(Keyboard_LEDIndex.M5, DeviceKeys.G5),
            new(Keyboard_LEDIndex.LeftCtrl, DeviceKeys.LEFT_CONTROL),
            new(Keyboard_LEDIndex.LeftWindows, DeviceKeys.LEFT_WINDOWS),
            new(Keyboard_LEDIndex.LeftAlt, DeviceKeys.LEFT_ALT),
            new(Keyboard_LEDIndex.Space, DeviceKeys.SPACE),
            new(Keyboard_LEDIndex.RightAlt, DeviceKeys.RIGHT_ALT),
            new(Keyboard_LEDIndex.Fn, DeviceKeys.FN_Key),
            new(Keyboard_LEDIndex.Menu, DeviceKeys.APPLICATION_SELECT),
            new(Keyboard_LEDIndex.RightCtrl, DeviceKeys.RIGHT_CONTROL),
            new(Keyboard_LEDIndex.PadMinus, DeviceKeys.NUM_MINUS),
            new(Keyboard_LEDIndex.PadAsterisk, DeviceKeys.NUM_ASTERISK),
            new(Keyboard_LEDIndex.PadForwardSlash, DeviceKeys.NUM_SLASH),
            new(Keyboard_LEDIndex.PadNumLock, DeviceKeys.NUM_LOCK),
            new(Keyboard_LEDIndex.PageUp, DeviceKeys.PAGE_UP),
            new(Keyboard_LEDIndex.Home, DeviceKeys.HOME),
            new(Keyboard_LEDIndex.Insert, DeviceKeys.INSERT),
            new(Keyboard_LEDIndex.PadPlus, DeviceKeys.NUM_PLUS),
            new(Keyboard_LEDIndex.Pad9, DeviceKeys.NUM_NINE),
            new(Keyboard_LEDIndex.Pad8, DeviceKeys.NUM_EIGHT),
            new(Keyboard_LEDIndex.Pad7, DeviceKeys.NUM_SEVEN),
            new(Keyboard_LEDIndex.PageDown, DeviceKeys.PAGE_DOWN),
            new(Keyboard_LEDIndex.End, DeviceKeys.END),
            new(Keyboard_LEDIndex.Delete, DeviceKeys.DELETE),
            new(Keyboard_LEDIndex.PrintScreen, DeviceKeys.PRINT_SCREEN),
            new(Keyboard_LEDIndex.Pad6, DeviceKeys.NUM_SIX),
            new(Keyboard_LEDIndex.Pad5, DeviceKeys.NUM_FIVE),
            new(Keyboard_LEDIndex.Pad4, DeviceKeys.NUM_FOUR),
            new(Keyboard_LEDIndex.Pad1, DeviceKeys.NUM_ONE),
            new(Keyboard_LEDIndex.UpArrow, DeviceKeys.ARROW_UP),
            new(Keyboard_LEDIndex.LeftArrow, DeviceKeys.ARROW_LEFT),
            new(Keyboard_LEDIndex.ScrollLock, DeviceKeys.SCROLL_LOCK),
            new(Keyboard_LEDIndex.PadEnter, DeviceKeys.NUM_ENTER),
            new(Keyboard_LEDIndex.Pad3, DeviceKeys.NUM_THREE),
            new(Keyboard_LEDIndex.Pad2, DeviceKeys.NUM_TWO),
            new(Keyboard_LEDIndex.PadFullstop, DeviceKeys.NUM_PERIOD),
            new(Keyboard_LEDIndex.Pad0, DeviceKeys.NUM_ZERO),
            new(Keyboard_LEDIndex.RightArrow, DeviceKeys.ARROW_RIGHT),
            new(Keyboard_LEDIndex.DownArrow, DeviceKeys.ARROW_DOWN),
            new(Keyboard_LEDIndex.Pause, DeviceKeys.PAUSE_BREAK),
            new(Keyboard_LEDIndex.Logo, DeviceKeys.LOGO)
        };

    internal static readonly KeyValuePair<Mouse_LEDIndex, DeviceKeys>[] MouseMapping = {
        new (Mouse_LEDIndex.LED0, DeviceKeys.MOUSEPADLIGHT1),
        new (Mouse_LEDIndex.LED1, DeviceKeys.MOUSEPADLIGHT2),
        new (Mouse_LEDIndex.LED2, DeviceKeys.MOUSEPADLIGHT3),
        new (Mouse_LEDIndex.LED3, DeviceKeys.MOUSEPADLIGHT4),
        new (Mouse_LEDIndex.LED4, DeviceKeys.MOUSEPADLIGHT5),
        new (Mouse_LEDIndex.LED5, DeviceKeys.MOUSEPADLIGHT6),
        new (Mouse_LEDIndex.LED6, DeviceKeys.MOUSEPADLIGHT7),
        new (Mouse_LEDIndex.LED7, DeviceKeys.MOUSEPADLIGHT8),
        new (Mouse_LEDIndex.LED8, DeviceKeys.MOUSEPADLIGHT9),
        new (Mouse_LEDIndex.LED9, DeviceKeys.MOUSEPADLIGHT10),
        new (Mouse_LEDIndex.LED10, DeviceKeys.MOUSEPADLIGHT11),
        new (Mouse_LEDIndex.Logo, DeviceKeys.Peripheral_Logo),
        new (Mouse_LEDIndex.Wheel, DeviceKeys.Peripheral_ScrollWheel)
    };
}