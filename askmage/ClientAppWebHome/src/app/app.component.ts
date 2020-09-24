import { Component } from '@angular/core';
declare var $: any;
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  title = 'app';

  ngOnInit(): void {
    //Called after the constructor, initializing input properties, and the first call to ngOnChanges.
    //Add 'implements OnInit' to the class.
    $( document ).ready(function() {
      /* progress bar */
      if($('#loadingBar').length > 0){
          var i = 0;
          if(i == 0){
              i = 1;
              var width = 1;
              var id = setInterval(frame, 15);
              function frame() {
                  if (width >= 100) {
                      clearInterval(id);
                      i = 0;
                      //window.location.replace("counter");
                  } else {
                      width++;
                      $('.bar').css("width",width +"%");
                      $('.loading-percent').text(width + "%");
                  }
              }
              
          }
      }
    });
  }
}
