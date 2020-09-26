import { Component, OnInit } from '@angular/core';
declare var $: any;
@Component({
  selector: 'app-loading',
  templateUrl: './loading.component.html',
  styleUrls: ['./loading.component.css']
})
export class LoadingComponent implements OnInit {

  constructor() { }
  ngOnInit() {
    this.onLoading();
  }

  onLoading() {
    //$(document).ready(function () {
    /* progress bar */
    if ($('#loadingBar').length > 0) {
      var i = 0;
      if (i == 0) {
        i = 1;
        var width = 1;
        //var id = setInterval(frame, 15);
        var id = setInterval(() => {
          frame();
        }, 15);
        function frame() {
          if (width == 100) {
            clearInterval(id);
            i = 0;
            //window.location.replace("home");
            window.location.href = '/home';
          } else {
            width++;
            $('.bar').css("width", width + "%");
            $('.loading-percent').text(width + "%");
          }
        }
      }
    }
    //});
  }
}
