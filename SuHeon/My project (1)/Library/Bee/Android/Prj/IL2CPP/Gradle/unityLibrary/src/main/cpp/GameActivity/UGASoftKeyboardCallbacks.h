DECLARE_INSTANCE_METHOD(UnitySoftKeyboard, void, SetText, (const std::string& text), (text))
DECLARE_INSTANCE_METHOD(UnitySoftKeyboard, void, SetTextSelection, (const Range& textSelection), (textSelection))
DECLARE_INSTANCE_METHOD(UnitySoftKeyboard, void, Show, (const ShowParams* showParams, uint32_t sizeOfShowParams), (showParams, sizeOfShowParams))
DECLARE_INSTANCE_METHOD(UnitySoftKeyboard, void, Hide, (), ())
DECLARE_INSTANCE_METHOD(UnitySoftKeyboard, void, SetCharacterLimit, (uint32_t characterLimit), (characterLimit))
DECLARE_INSTANCE_METHOD(UnitySoftKeyboard, const std::string&, GetText, () const, ())
DECLARE_INSTANCE_METHOD(UnitySoftKeyboard, Range , GetTextSelection, () const, ())