import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AppConstantsService
{
  readonly apiUrl: string = 'http://' + location.hostname + ':5020';
}
