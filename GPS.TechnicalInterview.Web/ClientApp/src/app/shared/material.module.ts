import { NgModule } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSelectModule } from '@angular/material/select';
import { MatTableModule } from '@angular/material/table';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatMenuModule } from '@angular/material/menu'
import { MatDialogModule } from '@angular/material/dialog'
import { MatSnackBarModule } from '@angular/material/snack-bar'

@NgModule({
  exports: [
      MatCardModule, 
      MatFormFieldModule, 
      MatTableModule, 
      MatSelectModule, 
      MatInputModule, 
      MatButtonModule,
      MatMenuModule,
      MatDialogModule,
      MatSnackBarModule
    ],
})
export class MaterialModule {}
