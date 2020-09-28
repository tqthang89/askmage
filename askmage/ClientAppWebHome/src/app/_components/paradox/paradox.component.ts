import { Component, OnInit } from '@angular/core';
//import * as Highcharts from 'highcharts';
import * as Highcharts from 'highcharts/highcharts.src';
import highcharts3D from 'highcharts/highcharts-3d.src';
highcharts3D(Highcharts);

import { ParadoxService } from 'src/app/_service/paradox_service';

@Component({
  selector: 'app-paradox',
  templateUrl: './paradox.component.html',
  styleUrls: ['./paradox.component.css']
})
export class ParadoxComponent implements OnInit {
  options: any;
  constructor() {paradoxservice: ParadoxService}

  /// Chart bên phải
  md : number; ma : number; hd : number; ha : number; tod : number; toa : number; kd : number; ka : number; tud : number; tua : number;
  kim:number;thuy:number;moc:number;hoa:number;tho:number;
  namhoagiap:string;namlist:string;menh:string;

  // Thông tin bên trái
  tilenguhanh : string;tenuser:string;


  ngOnInit() {

    this.tilenguhanh="Thủy : 22% : Thủy là đại diện cho cung chồng và cung quan quyền , mệnh có thủy và hỏa đều đạt trên mức trung bình (20%) là người lưỡng toàn cả tiền tài và công danh . Nhưng hỏa quá nhiều 36% cũng là điều bất lợi về sau này.<br/>IT test.";
  
    Highcharts.chart('container', {
      chart: {
          type: 'pie',
          options3d: {
              enabled: true,
              alpha: 50,
              beta: 0
          },
          width:350,
          height:270,
          backgroundColor: 'transparent'
      },
      title: {
          text:""
      },
      accessibility: {
          point: {
               valueSuffix: '%'
          }
      },
      credits:{
        enabled:false
      },
      tooltip: {
        enabled:false
          //pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
      },
      plotOptions: {
          pie: {
              allowPointSelect: false,
              cursor: 'pointer',
              depth: 35,
              dataLabels: {
                  enabled: false,
                  format: '{point.name}'
              },
              colors: ['#ffde12', '#2da9e1', '#3db54a', '#f15822', '#8b5f3d']
          }
      },
      series: [{
          type: 'pie',
          name: 'Browser share',
          data: [
              ['Kim', this.kim],
              ['Thủy', this.thuy],
              {
                  name: 'Mộc',
                  y: this.moc,
                  sliced: true,
                  selected: true
              },
              ['Hỏa', this.hoa],
              ['Thổ', this.tho]
          ]
      }]
  });

  }

}
