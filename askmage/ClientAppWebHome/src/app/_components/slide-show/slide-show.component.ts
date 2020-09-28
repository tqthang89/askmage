import { Component, OnInit } from '@angular/core';
@Component({
  selector: 'app-slide-show',
  templateUrl: './slide-show.component.html',
  styleUrls: ['./slide-show.component.css']
})
export class SlideShowComponent implements OnInit {
 
  constructor() { }
  startIndex = 0;
  Imagedata = [
    {url : '../../../assets/images/avatar-team.jpg'}
  ]
  ngOnInit() {
    this.Repeat();
  }
  Repeat() {
    setTimeout(() => {
      this.__FunctionSlide();
      this.Repeat();
    }, 2000);
  }
  __FunctionSlide() {
    const slides = Array.from(document.getElementsByClassName('mall-show-slide'));
    if (slides === []) {
      this.Repeat();
    }
    for (const x of slides) {
      const y = x as HTMLElement;
      //y.style.display = 'none';
      y.setAttribute('style', 'display: none');
    }
    if (this.startIndex > slides.length - 1) {
      this.startIndex = 0;
      const slide = slides[this.startIndex] as HTMLElement;
      //slide.style.display = 'block';
      slide.setAttribute('style', 'display: block');
      this.startIndex++;
    } else {

      const slide = slides[this.startIndex] as HTMLElement;
      //slide.style.display = 'block';
      slide.setAttribute('style', 'display: block');
      this.startIndex++;
    }
  }
}
