Module ModuleWidget

    Friend i As Integer = -1
    Public flagInventory As Boolean = False

    Public pbxWarray() As PictureBox = {InventoryForm.pbxw2, InventoryForm.pbxw3, InventoryForm.pbxw4, InventoryForm.pbxw5, InventoryForm.pbxw6, InventoryForm.pbxw7}

    Public bow As Widget = New Widget(1, "bow", My.Resources.bow2)
    Public potion As Widget = New Widget(2, "potion", My.Resources.potion2)
    Public sword As Widget = New Widget(3, "sword", My.Resources.sword2)
    Public gem As Widget = New Widget(4, "gem", My.Resources.gem2)
    Public box As Widget = New Widget(5, "box", My.Resources.box2)
    Public staff As Widget = New Widget(6, "staff", My.Resources.staff2)

    Friend inventory() As Widget = {bow, potion, sword, gem, box, staff}
End Module
