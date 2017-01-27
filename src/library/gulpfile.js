'use strict';

var gulp = require('gulp');
var sass = require('gulp-sass');

gulp.task('sass', function () {
    return gulp.src('./wwwroot/css/**/*.scss')
      .pipe(sass().on('error', sass.logError))
      .pipe(gulp.dest(file => file.base));
});

gulp.task('watch', function () {
    gulp.watch('./wwwroot/css/**/*.scss', ['sass']);
});

gulp.task('default', ['sass']);