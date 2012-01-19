﻿function require-param {
  param($value, $paramNames)
  
  if ($value -eq $null) {
    write-error "The parameter -$paramName is required."
    exit 1
  }
}

function print-error {
    param($value)
    Write-Host $value -foregroundcolor White -backgroundcolor Red
}

function print-warning {
    param($value)
    Write-Host $value -foregroundcolor Red -backgroundcolor Yellow
}

function print-success {
    param($value)
    Write-Host $value -foregroundcolor Black -backgroundcolor Green
}

function print-message {
    param($value)
    Write-Host $value -foregroundcolor Black -backgroundcolor White
}


function require-Module {
    param([string]$name)
    if(-not(Get-Module -name $name)){
        if(Get-Module -ListAvailable | Where-Object { $_.name -eq $name }) {
           write-host "Module is avalible and will be loaded."
           Import-Module -name $name  
        } else {
            write-error "The module '$name' is required."
            exit 1
        }
    }
}