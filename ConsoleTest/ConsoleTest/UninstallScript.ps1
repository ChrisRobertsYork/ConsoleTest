$app = Get-WmiObject -Class Win32_Product -computer $server | Where-Object
{ 
    $_.IdentifyingNumber -match "95406415-693e-4b6b-adf3-1eddf39a5c30" 
}
$app.Uninstall()