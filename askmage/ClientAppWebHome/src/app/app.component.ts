import { Component } from '@angular/core';
import { IpServiceService } from './_service/ip-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  title = 'app';
  _intervalAccess;

  constructor(private ip: IpServiceService) { }
  ngOnInit(): void {
    this._intervalAccess = setInterval(() => {
      let _acc = JSON.parse(localStorage.getItem('Access'));
      console.log('_acc ' + JSON.stringify(_acc));
      if (_acc !== null && _acc !== undefined) {
        this.ip.EmmployeeAccess_UpdateTime(_acc).subscribe(resAccess => { console.log('resAccess ' + JSON.stringify(resAccess)) });
      }
    }, 30000);
  }


} 
