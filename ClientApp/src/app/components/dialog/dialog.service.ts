import { Injectable } from '@angular/core';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { DialogComponent } from './dialog.component';
import { Observable } from 'rxjs';
import { map, take } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class DialogService {

  dialogRef: MatDialogRef<DialogComponent>;
  constructor(private dialog: MatDialog) { }

  public open(options: any) {
    this.dialogRef = this.dialog.open(DialogComponent,
    {
      data: options
    });
  }

  public done(): Observable<any> {
    return this.dialogRef.afterClosed().pipe(take(1), map(res => {
        return res;
      }
    ));
  }
}
