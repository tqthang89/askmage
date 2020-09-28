import { Component, OnInit } from '@angular/core';
//import * as Highcharts from 'highcharts';
import * as Highcharts from 'highcharts/highcharts.src';
import highcharts3D from 'highcharts/highcharts-3d.src';
highcharts3D(Highcharts);
import { HttpClient, HttpParams } from '@angular/common/http';
import { ParadoxService } from 'src/app/_service/paradox_service';

@Component({
  selector: 'app-paradox',
  templateUrl: './paradox.component.html',
  styleUrls: ['./paradox.component.css']
})
export class ParadoxComponent implements OnInit {
  options: any;
  constructor(private paradoxservice: ParadoxService,private http: HttpClient) {}

  /// Chart bên phải
  md : number; ma : number; hd : number; ha : number; tod : number; toa : number; kd : number; ka : number; tud : number; tua : number;
  kim:number;thuy:number;moc:number;hoa:number;tho:number;
  namhoagiap:string;namlist:string;menh:string;

  // Thông tin bên trái
  tilenguhanh : string;tenuser:string;

  ngOnInit() {
    this.paradoxservice.getparadox(1).subscribe(result => {
      if(result['table'][0] != null)
      {
        
        this.md=result['table'][0].md;
        this.ma=result['table'][0].ma;
        this.hd=result['table'][0].hd;
        this.ha=result['table'][0].ha;
        this.tod=result['table'][0].tod;
        this.toa=result['table'][0].toa;
        this.kd=result['table'][0].kd;
        this.ka=result['table'][0].ka;
        this.tud=result['table'][0].tud;
        this.tua=result['table'][0].tua;
        this.kim=result['table'][0].kim;
        this.thuy=result['table'][0].thuy;
        this.moc=result['table'][0].moc;
        this.hoa=result['table'][0].hoa;
        this.tho=result['table'][0].tho;
        this.namhoagiap=result['table'][0].namhoagiap;
        this.namlist=result['table'][0].namlist;
        this.menh=result['table'][0].menh;
        this.tilenguhanh=result['table'][0].tilenguhanh;
        this.tenuser=result['table'][0].tenuser;

      
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

      
    });
    

  }

}
